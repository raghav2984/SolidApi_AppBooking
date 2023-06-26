using System.Runtime.Serialization;

namespace src.Services.Exceptions
{
    [Serializable]
    internal class DateFormatException : Exception
    {
        public DateFormatException() : base("Error in date/time format.Please input in the following format: \"22/02/2023 04:00 pm\r\n")
        {
        }

        public DateFormatException(string? message) : base(message)
        {
        }

        public DateFormatException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DateFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}