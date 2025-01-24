namespace GeometryLibrary.Calculators
{
    public class ShapeCalculator
    {
        public double CalculateArea(Interfaces.IAreaCalculator shape)
        {
            return shape.CalculateArea();
        }
    }
}