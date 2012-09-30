namespace NeatoAPI
{
    using System;

    /// <summary>
    /// This exception is thrown when a device unexpectedly turns out not to be a Neato.
    /// </summary>
    [Serializable]
    public class NotANeatoException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotANeatoException"/> class.
        /// </summary>
        /// <param name="additionalInformation">
        /// The additional information.
        /// </param>
        public NotANeatoException(string additionalInformation)
            : base("This device does not reply in the manner fitting of a Neato.\n\"" + additionalInformation + "\"")
        {
        }
    }

    /// <summary>
    /// This exception is thrown when a method call requires TestMode to be active, but isn't.
    /// </summary>
    [Serializable]
    public class NotInTestModeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotInTestModeException"/> class.
        /// </summary>
        /// <param name="additionalInformation">
        /// The additional information.
        /// </param>
        public NotInTestModeException(string additionalInformation)
            : base("To use this method the Neato must be in Test Mode.\n\"" + additionalInformation + "\"")
        {
        }
    }
}
