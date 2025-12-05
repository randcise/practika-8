using System;
using System.Globalization;

delegate double Operation(double a, double b);

class Program
{
    static void Main()
    {
        Console.Write("Перше число: ");
        string? s1 = Console.ReadLine();

        Console.Write("Друге число: ");
        string? s2 = Console.ReadLine();

        if (!double.TryParse(s1, NumberStyles.Any, CultureInfo.InvariantCulture, out double a) &&
            !double.TryParse(s1, out a))
        {
            Console.WriteLine("Невірне число");
            return;
        }

        if (!double.TryParse(s2, NumberStyles.Any, CultureInfo.InvariantCulture, out double b) &&
            !double.TryParse(s2, out b))
        {
            Console.WriteLine("Невірне число");
            return;
        }

        Console.Write("Операція (+, -, *, /): ");
        string? op = Console.ReadLine();

        Operation? del = op switch
        {
            "+" => Add,
            "-" => Sub,
            "*" => Mul,
            "/" => Div,
            _ => null
        };

        if (del == null)
        {
            Console.WriteLine("Невідома операція");
            return;
        }

        Console.WriteLine($"Результат: {del(a, b)}");
    }

    static double Add(double a, double b) => a + b;
    static double Sub(double a, double b) => a - b;
    static double Mul(double a, double b) => a * b;

    static double Div(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Помилка: ділення на нуль!");
            return double.NaN;
        }
        return a / b;
    }
}
