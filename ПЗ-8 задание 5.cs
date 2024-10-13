using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пз_8
{
    internal class задание_5
    {
        static void ain(string[] args)
        {
            Console.WriteLine("введите сумму вклада");
            int num = (int)Convert.ToDouble(Console.ReadLine());
            {
                if (num < 100)
                {
                    num = (int)(num * 1.05 + 15);

                    Console.WriteLine("ваш итоговый вклад равен " + num);
                }
                else
                if (num >= 100 & num <= 200)

                {
                    num = (int)(num * 1.07 + 15);
                    Console.WriteLine("ваш итоговый вклад равен " + num);
                }
                else

                {
                    num = (int)(num * 1.1 + 15);
                    Console.WriteLine("ваш итоговый вклад равен " + num);
                }

            }
        }
    }
}
