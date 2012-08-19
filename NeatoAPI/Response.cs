using System;

namespace Neato
{
    public class Response
    {
        private String _info;
        public Response(String response)
        {
            _info = response;
        }

        public String GetText()
        {
            return _info;
        }
    }
}
