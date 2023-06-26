using System.Runtime.Serialization;

namespace src.Services.Exceptions
{
    [Serializable]
    internal class NameEmptyException : Exception
    {
        public NameEmptyException() : base(Environment.NewLine + "Name cannot be empty..." + Environment.NewLine)
        {
        }

        //public DoctorNameEmptyException(string? message) : base(message)
        //{
        //}

        //public DoctorNameEmptyException(string? message, Exception? innerException) : base(message, innerException)
        //{
        //}

        //protected DoctorNameEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }
}