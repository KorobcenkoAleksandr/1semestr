using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите последовательность целых чисел 0 для завершения:");

        int number;
        int maxNumber = int.MinValue; 
        int maxNumberIndex = 0; 
        int currentIndex = 0; 

        do
        {
            number = Convert.ToInt32(Console.ReadLine());

            if (number != 0 && number > maxNumber)
            {
                maxNumber = number;
                maxNumberIndex = currentIndex;
            }

            currentIndex++; 

        } while (number != 0); 

        Console.WriteLine($"Максимальное число: {maxNumber}, порядковый номер: {maxNumberIndex + 1}");
    }
}