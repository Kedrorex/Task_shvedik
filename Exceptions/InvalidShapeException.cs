namespace GeometryLibrary.Exceptions
{
    public class InvalidShapeException : Exception
    {
        public InvalidShapeException(string message) : base(message) { }

        public InvalidShapeException(string message, Exception innerException) 
            : base(message, innerException) { }
    }
}