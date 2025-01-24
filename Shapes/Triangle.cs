namespace GeometryLibrary.Shapes
{
    public class Triangle : Shape, Interfaces.IRightAngleCheckable
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new GeometryLibrary.Exceptions.InvalidShapeException("Стороны треугольника должны быть положительными числами.");

            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new GeometryLibrary.Exceptions.InvalidShapeException("Треугольник с такими сторонами не существует.");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double CalculateArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        // Реализация метода из интерфейса IRightAngleCheckable
        public bool IsRightAngled()
        {
            double[] sides = new[] { _sideA, _sideB, _sideC };
            Array.Sort(sides);

            // Проверка по теореме Пифагора
            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 0.0001;
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}