using System;

namespace Composite
{
    public class UnsupportedOperationException : Exception
    {
        public UnsupportedOperationException()
        {
        }

        public UnsupportedOperationException(string message) : base(message)
        {
            Message = message;
        }

        public override string Message { get; }
    }
}