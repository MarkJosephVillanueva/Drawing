using System;

namespace Drawing.Exceptions
{
    public class OutOfCanvasException : Exception
    {
        public OutOfCanvasException()
        {
        }

        public OutOfCanvasException(string message)
            : base(message)
        {
        }

        public OutOfCanvasException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
