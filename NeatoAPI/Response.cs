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

            bool first = true;

            foreach (var line in response.Split('\n'))
            {
                if (first)
                {
                    first = false;
                    continue;
                }

                var cut = line.Trim().Split(',');

                this.data.Add(cut[0], new List<string>());

                for (var i = 1; i < cut.Length; i++)
                {
                    this.data[cut[0]].Add(cut[i]);
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
        /// TODO: Write doc.
        /// </summary>
        /// <param name="identifier">
        /// The identifier.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<string> GetLine(string identifier)
        {
            return this.data[identifier];
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
