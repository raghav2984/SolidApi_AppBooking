using System.Runtime.Serialization;

namespace src.Services.Exceptions
{
    [Serializable]
    internal class ApptSlotExistException : Exception
    {
        public ApptSlotExistException() : base(Environment.NewLine + "Selected time slot is not free" + Environment.NewLine) 
        {
        }

    }
}