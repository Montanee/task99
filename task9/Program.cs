using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 2, 5, 8, 11, 14, 17, 20, 23 };

        Console.WriteLine("Нечетные числа из массива:");
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}
