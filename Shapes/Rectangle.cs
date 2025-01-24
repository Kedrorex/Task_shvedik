namespace GeometryLibrary.Shapes
{
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new GeometryLibrary.Exceptions.InvalidShapeException("Ширина и высота должны быть положительными числами.");

            _width = width;
            _height = height;
        }

        public override double CalculateArea()
        {
            return _width * _height;
        }
    }
}