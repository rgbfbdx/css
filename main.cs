using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 - з Фаренгейта в Цельсій");
        Console.WriteLine("2 - з Цельсія в Фаренгейт");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Введіть температуру: ");
        double t = double.Parse(Console.ReadLine());

        if (choice == 1)
            Console.WriteLine((t - 32) * 5 / 9);
        else
            Console.WriteLine(t * 9 / 5 + 32);
    }
}
