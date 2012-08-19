using System;
using System.Collections.Generic;

namespace Neato
{
    /// <summary>
    /// Represents a response from the Neato. Parsed .csv format, ish.
    /// </summary>
    public class Response
    {
        private Dictionary<string, string> _csv;
        private String _info;
        public Response(String response)
        {
            // TODO: Parse into Dictionary<x,y> form.
            _info = response;
        }

        public String GetText()
        {
            return _info;
        }
    }
}
