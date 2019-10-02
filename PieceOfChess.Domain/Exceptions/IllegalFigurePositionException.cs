using System;
using System.Runtime.Serialization;

namespace PieceOfChess.Domain.Exceptions
{
    public class IllegalFigurePositionException : Exception
    {
        public IllegalFigurePositionException()
        {
        }

        public IllegalFigurePositionException(string message) : base(message)
        {
        }

        public IllegalFigurePositionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IllegalFigurePositionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
