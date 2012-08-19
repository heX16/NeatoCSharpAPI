using System;
using System.IO.Ports;

namespace Neato
{
    class Connection
    {
        private SerialPort _port;

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
