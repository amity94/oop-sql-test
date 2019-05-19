using System;
using System.Runtime.Serialization;

namespace SecretAgent
{
    [Serializable]
    internal class ItemAlreadyExsistsException : Exception
    {
        public ItemAlreadyExsistsException()
        {
        }

        public ItemAlreadyExsistsException(string message) : base(message)
        {
        }

        public ItemAlreadyExsistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ItemAlreadyExsistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}