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
        private readonly String _raw;
        public Response(String response)
        {
            _raw = response;

            // TODO: Parse into Dictionary<x,y> form.
        }

        public String GetRaw()
        {
            return _raw;
        }
    }
}
