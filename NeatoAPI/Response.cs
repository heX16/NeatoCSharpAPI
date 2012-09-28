// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Response.cs" company="N/A">
// TODO: Update copyright text.
// </copyright>
// <summary>
//   Represents a response from the Neato. Parsed .csv format, ish.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NeatoAPI
{
    using System;
    using System.Collections.Generic;

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
