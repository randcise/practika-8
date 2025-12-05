using System;
using System.Globalization;

delegate double FuncDelegate(double x);

class Program
{
    static void Main()
    {
        Console.Write("Введіть значення x: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Потрібно було ввести число");
            return;
        }

        if (!double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double x) &&
            !double.TryParse(input, out x))
        {
            Console.WriteLine("Некоректне число");
            return;
        }

        FuncDelegate func = x > 0 ? CosPlusOne : OneMinusTwoSin;

        double result = func(x);
        Console.WriteLine($"F({x}) = {result}");
    }

    static double CosPlusOne(double x) => Math.Cos(x + 1);
    static double OneMinusTwoSin(double x) => 1 - 2 * Math.Sin(x);
}
