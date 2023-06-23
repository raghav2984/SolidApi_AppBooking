using System.Runtime.Serialization;

namespace src.Services.Exceptions
{
    [Serializable]
    internal class DbEntryExistException : Exception
    {
        public DbEntryExistException() : base("Doctor name exist in the database. Cannot create new entry!!!" + Environment.NewLine)
        {
        }

        //public DoctorAlreadyExistException(string? message) : base(message)
        //{
        //}

        //public DoctorAlreadyExistException(string? message, Exception? innerException) : base(message, innerException)
        //{
        //}

        //protected DoctorAlreadyExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }
}