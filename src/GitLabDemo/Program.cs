using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть ваше ім'я: ");
        string name = Console.ReadLine();

        Console.Write("Введіть ваш вік: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Ім'я: {name}, Вік: {age}");
    }
}
