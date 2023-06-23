using System.Runtime.Serialization;

namespace src.Services.Exceptions
{
    [Serializable]
    internal class NameAlreadyExistsException : Exception
    {
        //public DoctorNameAlreadyExistsException()
        //{
        //}

        public NameAlreadyExistsException(string? doctorName) : base("Name : " + doctorName + " exist. Cannot create another entry..." + Environment.NewLine) 
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