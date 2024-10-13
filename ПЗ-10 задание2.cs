using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите последовательность целых чисел для завершения:");

        int num;
        int maxNum = int.MinValue; 
        int maxNumIndex = 0; 
        int currentIndex = 0; 

        do
        {
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 0 & number > maxNumber)
            {
                maxNum = number;
                maxNumIndex = currentIndex;
            }

            currentIndex++; 

        } while (num != 0); 

        Console.WriteLine($"Максимальное число: {maxNum}, порядковый номер: {maxNumIndex + 1}");
    }
}
