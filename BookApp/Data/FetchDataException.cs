using System.Runtime.Serialization;

namespace BookApp.Data
{
    [Serializable]
    internal class FetchDataException : Exception
    {
        public FetchDataException()
        {
        }

        public FetchDataException(string? message) : base(message)
        {
        }

        public FetchDataException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FetchDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}