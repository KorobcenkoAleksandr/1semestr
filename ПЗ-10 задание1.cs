
using System;

    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Введите последовательность целых чисел для завершения");

        int num;
        int minNumber = int.MaxValue;
        do
        {
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 0 & num < minNumber)
            {
                minNumber = number;
            }

        } while (num != 0); 

        Console.WriteLine($"Минимальное число: {minNumber}");
    }
}
    
