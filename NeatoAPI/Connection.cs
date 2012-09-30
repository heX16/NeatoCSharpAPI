namespace NeatoAPI
{
    using System;
    using System.IO;
    using System.IO.Ports;
    using System.Threading;

    /// <summary>
    /// Represents the Serial Port connection to the Neato device.
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// The SerialPort object used to communicate with the Neato.
        /// </summary>
        private readonly SerialPort neatoPort;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Connection"/> class.
        /// </summary>
        /// <param name="comPort">Name of port to connect to.</param>
        /// <exception cref="NotANeatoException">If device does not respond to the GetVersion command, it's probably not a Neato.</exception>
        public Connection(string comPort)
        {
            // Values are irrelevant, quote from Programmers guide:
            // "The communication parameters (Baud, start/stop bits,parity, etc.) are unimportant. They apply only to a real com port."
            this.neatoPort = new SerialPort(comPort, 4711, Parity.None, 7, StopBits.One) { ReadTimeout = 500, WriteTimeout = 500 };
            this.Port = comPort;

            // Connect to the COM-port.
            this.neatoPort.Open();

            // Let's find out if we're connected to a Neato...
            if (!this.SendCommand("GetVersion").GetRaw().Contains("Component,Major,Minor,Build"))
            {
                throw new NotANeatoException("Response to GetVersion does not contain headers \"Component,Major,Minor,Build\".");
            }
        }

        /// <summary>
        /// Gets the COM port used to connect to this Neato.
        /// </summary>
        public string Port { get; private set; }

        /// <summary>
        /// Checks if connection to Neato is open.
        /// </summary>
        /// <returns>True if connected to the Neato, false if not.</returns>
        public bool IsConnected()
        {
            if (this.neatoPort == null)
            {
                return false;
            }

            return this.neatoPort.IsOpen;
        }
        
        /// <summary>
        /// Disconnects from Neato.
        /// </summary>
        public void Disconnect()
        {
            if (this.neatoPort == null)
            {
                // Don't have to close something that doesn't exist...
                return;
            }
            
            this.neatoPort.Close();
        }

        /// <summary>
        /// Sends a command to the Neato and reads the response.
        /// </summary>
        /// <param name="command">Command (and any flags) to send to Neato.</param>
        /// <returns>Response file with Neato response. Can be empty.</returns>
        /// <exception cref="IOException">Thrown if no connection to Neato has been established.</exception>
        public Response SendCommand(string command)
        {
            return this.SendCommand(command, false);
        }
        
        /// <summary>
        /// Sends a command to the Neato. Waiting for a response will delay this call by roughly 150 milliseconds.
        /// </summary>
        /// <param name="command">Command (and any flags) to send to Neato.</param>
        /// <param name="quick">True ignores any responses and returns an empty response file.</param>
        /// <returns>Response file with Neato response. Can be empty.</returns>
        /// <exception cref="IOException">Thrown if no connection to Neato has been established.</exception>
        /// <exception cref="ArgumentException">Thrown if command sent is unknown to Neato.</exception>
        public Response SendCommand(string command, bool quick)
        {
            if (!this.IsConnected())
            {
                throw new IOException("No connection to Neato established.");
            }

            // Empty anything lingering in the buffer.
            this.neatoPort.DiscardInBuffer();

            // Send command to Neato.
            this.neatoPort.WriteLine(command);

            if (quick)
            {
                // Save some time by not listening to Neato.
                return new Response(string.Empty);
            }

            // Wait a little bit for Neato's response.
            Thread.Sleep(150);
            string tmp = this.neatoPort.ReadExisting();
            
            if (tmp.Length == 0)
            {
                // No response received from command.
                return new Response(string.Empty);
            }
            
            // Cut off first line, contains command sent.
            tmp = tmp.Substring(tmp.IndexOf('\n'));

            // Check if there are any new lines.
            if (tmp.Contains("\n"))
            {
                // Cut off last line, it will only contain Ctrl+Z control character.
                tmp = tmp.Substring(0, tmp.LastIndexOf('\n'));
            }

            // Look for errors reported by Neato.
            if (tmp.Contains("Unknown Cmd:") || tmp.Contains("Unrecognized Option"))
            {
                throw new ArgumentException(tmp);
            }
            
            return new Response(tmp);
        }
    }
}
