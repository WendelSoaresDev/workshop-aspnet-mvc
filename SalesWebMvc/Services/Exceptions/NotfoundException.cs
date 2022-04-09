using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotfoundException : ApplicationException
    {
        public NotfoundException(string message) : base(message)
        {
        }
    }
}
