using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пз_9
{
    internal class задание_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица умножения");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int результат = i * j;
                    Console.Write($"{i} * {j} = {результат}\t");
                }
            }
        }
    }
}
