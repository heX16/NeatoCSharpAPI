using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
