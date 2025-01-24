namespace GeometryLibrary.Shapes
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new GeometryLibrary.Exceptions.InvalidShapeException("Радиус должен быть положительным числом.");

            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}