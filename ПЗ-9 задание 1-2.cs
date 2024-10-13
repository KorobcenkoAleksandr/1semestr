using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пз_9
{
    internal class задание_1_2
    {
        static void ain(string[] args)
        {
            Console.WriteLine("введите сумму вклада");
            int num1 = (int)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("введите количество месяцев");
            int num2 = (int)Convert.ToDecimal(Console.ReadLine());
            int num3 = 0;
            int num4 = 0;
            while (num2 > 0)
            {
                num3 = (int)(num1 * 1.07);
                num2--;
                num4++;
                int num6 = num1;
                if (num4 == 12)
                {
                    int num5 = (int)(num1 + num3);
                    num1 = num5;
                    int year = 12;
                    int v = num4 - year;
                    num4 = v;
                }
                

            }
            Console.WriteLine("конечна сумма вклада с учетом начисления процентов за каждый месяц = " + num1);
        }

            
    }
}
