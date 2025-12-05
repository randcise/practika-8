using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть номер кольору (1–7): ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Потрібно було ввести число");
            return;
        }

        if (!int.TryParse(input, out int n) || n < 1 || n > 7)
        {
            Console.WriteLine("Число має бути від 1 до 7!");
            return;
        }

        Action? colorAction = n switch
        {
            1 => Red,
            2 => Orange,
            3 => Yellow,
            4 => Green,
            5 => Cyan,
            6 => Blue,
            7 => Violet,
            _ => null
        };

        colorAction?.Invoke();
    }

    static void Red()    => Print("червоний", 255, 0, 0);
    static void Orange() => Print("помаранчовий", 255, 165, 0);
    static void Yellow() => Print("жовтий", 255, 255, 0);
    static void Green()  => Print("зелений", 0, 128, 0);
    static void Cyan()   => Print("блакитний", 0, 255, 255);
    static void Blue()   => Print("синій", 0, 0, 255);
    static void Violet() => Print("фіолетовий", 128, 0, 128);

    static void Print(string name, int r, int g, int b)
        => Console.WriteLine($"{name} → RGB({r}, {g}, {b})");
}
