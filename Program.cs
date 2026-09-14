using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Красный текст в консоли!");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Зеленый текст в консоли!");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Синий текст в консоли!");

        Console.ResetColor(); 
    }
}
