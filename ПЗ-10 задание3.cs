using static System.Console;
using static System.Math;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            WriteLine("Введите значение x:");
            double x = Convert.ToDouble(ReadLine());

            double temp = x - 3; 

            double y = 4 * Pow(temp, 6) - 7 * Pow(temp, 3) + 2;

            WriteLine($"Значение y для x = {x}: {y}");
        }
    }
}