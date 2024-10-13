using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program3
{
    static void ain(string[] args)
    {
        Console.WriteLine("введите число");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 5)
            Console.WriteLine("Число либо равно 5, либо равно 10");
        else
        {
            Console.WriteLine("Неизвестное число");
        }
    }
}