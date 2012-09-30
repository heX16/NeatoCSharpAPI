namespace NeatoAPI
{
    using System.Collections.Generic;

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
        public Dictionary<string, List<string>> data;

        /// <summary>
        /// Initializes a new instance of the <see cref="Response"/> class.
        /// </summary>
        /// <param name="response">
        /// Response text received from the Neato.
        /// </param>
        public Response(string response)
        {
            this.raw = response;

            this.data = new Dictionary<string, List<string>>();

            foreach (var line in response.Split('\n'))
            {
                string cut = line.Trim();
                var tmp = new List<string>(cut.Split(','));
                this.data.Add(tmp[0], new List<string>(tmp.GetRange(1, tmp.Count - 1)));
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
    }
}
