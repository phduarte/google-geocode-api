using System;
using System.Runtime.Serialization;

namespace WappaMobile.ChallengeDev
{
    public class WappaMobileException : Exception
    {
        public WappaMobileException()
        {
        }

        public WappaMobileException(string message) : base(message)
        {
        }

        public WappaMobileException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WappaMobileException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
