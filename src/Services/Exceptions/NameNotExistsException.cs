using System.Runtime.Serialization;

namespace src.Services.Exceptions
{
    [Serializable]
    internal class NameNotExistsException : Exception
    {
        public NameNotExistsException(string? name) : base(Environment.NewLine + "Patient with name " + name + " is not registered in the system!!!" + Environment.NewLine)
        {
        }

    }
}