using System;

namespace SmsDotNet.Exceptions
{
    public class BadRequest : Exception
    {
        public BadRequest (string message) : base(message)
        {

        }
    }
}
