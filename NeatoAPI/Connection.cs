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

        /// <summary>
        /// Get a list of available COM ports on the current system.
        /// </summary>
        public static string[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }

        #endregion

        /// <summary>
        /// Creates a Connection object and attempts to connect to specified COM port.
        /// </summary>
        /// <param name="comPort">Name of port to connect to (eg. "COM3").</param>
        public Connection(string comPort)
        {
            // Values are inconsequential, quote from Programmers guide:
            // "The communication parameters (Baud, start/stop bits,parity, etc.) are unimportant. They apply only to a real com port."
            _port = new SerialPort(comPort, 4711, Parity.None, 7, StopBits.One) {ReadTimeout = 500, WriteTimeout = 500};

            try
            {
                _port.Open();
            }
            catch(Exception e)
            {
                // TODO: Perform some kind of exception handling!
                _port = null;
                throw new Exception("Neato Connection Error!",e);
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
            
            
            return new Response(tmp);
        }
    }
}
