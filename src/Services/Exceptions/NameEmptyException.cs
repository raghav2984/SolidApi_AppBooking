using System.Runtime.Serialization;

namespace src.Services.Exceptions
{
    [Serializable]
    internal class NameEmptyException : Exception
    {
        public NameEmptyException() : base("Doctor name cannot be empty...")
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