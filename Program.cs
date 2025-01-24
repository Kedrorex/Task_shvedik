using System;
using GeometryLibrary.Shapes;
using GeometryLibrary.Calculators;
using GeometryLibrary.Interfaces;

class Program
{
    static void Main()
    {
        try
        {
        // Создаем фигуры
        Circle circle = new Circle(5);
        Triangle triangle = new Triangle(3, 4, 5);
        Rectangle rectangle = new Rectangle(4, 5);

        // Используем ShapeCalculator для вычисления площади
        ShapeCalculator calculator = new ShapeCalculator();

        Console.WriteLine($"Площадь круга : {calculator.CalculateArea(circle)}");
        Console.WriteLine($"Площадь треугольника : {calculator.CalculateArea(triangle)}");
        Console.WriteLine($"Площадь прямоугольника : {calculator.CalculateArea(rectangle)}");
    }
        catch (GeometryLibrary.Exceptions.InvalidShapeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
