using System.Runtime.Serialization;

namespace src.Services.Exceptions
{
    [Serializable]
    internal class DoctorNameAlreadyExistsException : Exception
    {
        //public DoctorNameAlreadyExistsException()
        //{
        //}

        public DoctorNameAlreadyExistsException(string? doctorName) : base("Dotor with the name " + doctorName + " exisit. Cannot create another...") 
        {
        }
 

        //public DoctorNameAlreadyExistsException(string? message) : base(message)
        //{
        //}

        //public DoctorNameAlreadyExistsException(string? message, Exception? innerException) : base(message, innerException)
        //{
        //}

        //protected DoctorNameAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }
}