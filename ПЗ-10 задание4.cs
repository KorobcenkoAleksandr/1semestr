using static System.Console;
using static System.Math;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Введите координату x (1-8):");
        int x = Convert.ToInt32(ReadLine());
        WriteLine("Введите координату y (1-8):");
        int y = Convert.ToInt32(ReadLine());
        bool isWhite = ((x + y) % 2 == 0); 
        WriteLine($"Это квадрат белый? {!isWhite}");
    }
}