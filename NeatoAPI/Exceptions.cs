using System;

namespace Neato
{
    [Serializable]
    public class NotANeatoException : Exception
    {
        public NotANeatoException(string additionalInformation) : 
            base("This device does not reply in the manner fitting of a Neato.\n\"" + additionalInformation + "\"") { }
    }

    [Serializable]
    public class NotInTestModeException : Exception
    {
        public NotInTestModeException(string additionalInformation) : 
            base("To use this method the Neato must be in Test Mode.\n\""+ additionalInformation +"\"") { }
    }
}
