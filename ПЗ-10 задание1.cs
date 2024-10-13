
using System;

    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Введите последовательность целых чисел 0 для завершения");

        int number;
        int minNumber = int.MaxValue;
        do
        {
            number = Convert.ToInt32(Console.ReadLine());

            if (number != 0 && number < minNumber)
            {
                minNumber = number;
            }

        } while (number != 0); 

        Console.WriteLine($"Минимальное число: {minNumber}");
    }
}
    
