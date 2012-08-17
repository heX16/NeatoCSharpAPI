using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace Neato
{
    class Connection
    {
        private SerialPort _port;

        public Connection(string ComPort)
        {
            // Values are inconsequential, quote from Programmers guide:
            // "The communication parameters (Baud, start/stop bits,parity, etc.) are unimportant. They apply only to a real com port."
            _port = new SerialPort(ComPort, 4711, Parity.None, 7, StopBits.One);

            // Set other values for port.
            _port.ReadTimeout = 500;
            _port.WriteTimeout = 500;

            try
            {
                _port.Open();
            }
            catch(Exception e)
            {
                // TODO: Perform some kind of exception handling!
                _port = null;
                throw new Exception("Neato Connection Error!");
            }
        }

        public bool IsConnected()
        {
            return _port.IsOpen;
        }

        public void Disconnect()
        {
            _port.Close();
        }

        public Response SendCommand(string command)
        {
            _port.WriteLine(command);

            //String tmp = _port.ReadTo("\u001F");

            //return new Response(tmp);
            return null;
        }
    }
}
