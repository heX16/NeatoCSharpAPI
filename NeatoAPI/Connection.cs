using System;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace Neato
{
    /// <summary>
    /// Represents the Serial Port connection to the Neato device.
    /// </summary>
    public class Connection
    {
        #region Definitions and static methods.

        private SerialPort _port;
        public String Port { get; private set; }

        #endregion

        /// <summary>
        /// Creates a Connection object and attempts to connect to specified COM port.
        /// </summary>
        /// <param name="comPort">Name of port to connect to (eg. "COM3").</param>
        /// <exception cref="NotANeatoException">If device does not respond to the GetVersion command, it's probably not a Neato.</exception>
        public Connection(string comPort)
        {
            // Values are irrelevant, quote from Programmers guide:
            // "The communication parameters (Baud, start/stop bits,parity, etc.) are unimportant. They apply only to a real com port."
            _port = new SerialPort(comPort, 4711, Parity.None, 7, StopBits.One) {ReadTimeout = 500, WriteTimeout = 500};
            Port = comPort;

            try
            {
                // Connect to the COM-port.
                _port.Open();

                // Let's find out if we're connected to a Neato...
                if (! SendCommand("GetVersion").GetRaw().Contains("Component,Major,Minor,Build"))
                {
                    throw new NotANeatoException("Response to GetVersion does not contain headers \"Component,Major,Minor,Build\".");
                }
            }
            catch(Exception e)
            {
                // TODO: Perform some kind of exception handling!
                throw;
            }
        }

        /// <summary>
        /// Checks if connection to Neato is open.
        /// </summary>
        public bool IsConnected()
        {
            return _port.IsOpen;
        }
        
        /// <summary>
        /// Disconnects from Neato.
        /// </summary>
        public void Disconnect()
        {
            _port.Close();
        }

        /// <summary>
        /// Sends a command to the Neato and reads the response.
        /// </summary>
        /// <param name="command">Command (and any flags) to send to Neato.</param>
        /// <returns>Response file with Neato response. Can be empty.</returns>
        /// <exception cref="IOException">Thrown if no connection to Neato has been established.</exception>
        public Response SendCommand(string command)
        {
            return SendCommand(command, false);
        }
        
        /// <summary>
        /// Sends a command to the Neato. Waiting for a response will delay this call by ~150ms.
        /// </summary>
        /// <param name="command">Command (and any flags) to send to Neato.</param>
        /// <param name="quick">True ignores any responses and returns an empty response file.</param>
        /// <returns>Response file with Neato response. Can be empty.</returns>
        /// <exception cref="IOException">Thrown if no connection to Neato has been established.</exception>
        /// <exception cref="ArgumentException">Thrown if command sent is unknown to Neato.</exception>
        public Response SendCommand(string command, bool quick)
        {
            if(!IsConnected()) throw new IOException("No connection to Neato established.");

            // Empty anything lingering in the buffer.
            _port.DiscardInBuffer();

            // Send command to Neato.
            _port.WriteLine(command);

            if(quick)
            {
                // Save some time by not listening to Neato.
                return new Response("");
            }

            // Wait a little bit for Neato's response.
            Thread.Sleep(150);
            string tmp = _port.ReadExisting();
            
            if(tmp.Length == 0)
            {
                // No response received from command.
                return new Response("");
            }
            
            // Cut off first line, contains command sent.
            tmp = tmp.Substring(tmp.IndexOf('\n'));
            
            if(tmp.Contains("\n")) // Checks if there are any new lines.
            {
                // Cut off last line, it will only contain Ctrl+Z control character.
                tmp = tmp.Substring(0, tmp.LastIndexOf('\n'));
            }
            if(tmp.Contains("Unknown Cmd:"))
            {
                throw new ArgumentException(tmp);
            }
            
            return new Response(tmp);
        }
    }
}
