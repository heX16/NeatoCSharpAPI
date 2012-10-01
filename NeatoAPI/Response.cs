namespace NeatoAPI
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents a response from the Neato. 
    /// </summary>
    public class Response
    {
        /// <summary>
        /// The unmodified response data.
        /// </summary>
        private readonly string raw;

        /// <summary>
        /// The parsed form of the response.
        /// </summary>
        private readonly Dictionary<string, List<string>> data;

        /// <summary>
        /// Initializes a new instance of the <see cref="Response"/> class.
        /// </summary>
        /// <param name="response">
        /// Response text received from the Neato.
        /// </param>
        public Response(string response)
        {
            // Find data headers (Assumed to be first line. TODO: Verify this.
            var headers = response.Split('\n')[0].Trim().Split(',');

            this.raw = response;
            this.data = new Dictionary<string, List<string>>();

            foreach (var header in headers)
            {
                this.data.Add(header, new List<string>());
            }

            foreach (var line in response.Split('\n'))
            {
                var cut = line.Trim();
                var tmp = new List<string>(cut.Split(','));
                
                for (var i = 0; i < headers.Length; i++)
                {
                    this.data[headers[i]].Add(tmp[i]);
                }
            }
        }

        /// <summary>
        /// Retrieves the unmodified response text.
        /// </summary>
        /// <returns>
        /// String containing response text, possibly with newlines (\n).
        /// </returns>
        public string GetRaw()
        {
            return this.raw;
        }

        /// <summary>
        /// A textual representation of this response object. Can contain multiple lines.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/> representing this response's data.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// Isn't implemented yet, duh.
        /// </exception>
        public override string ToString()
        {
            var result = new StringBuilder();

            throw new NotImplementedException("Need to finalize parsed data structure first.");
        }
    }
}
