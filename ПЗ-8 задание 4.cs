using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program4
{
    static void ain(string[] args)
    {
        Console.WriteLine("введите сумму вклада");
        int num = (int)Convert.ToDouble(Console.ReadLine());
        {
            if (num < 100)
            {
                num = (int)(num * 1.05);

                Console.WriteLine("ваш итоговый вклад равен " + num);
            }
            else
            if (num >= 100 & num <= 200)

            {
                num = (int)(num * 1.07);
                Console.WriteLine("ваш итоговый вклад равен " + num);
            }
            else

            {
                num = (int)(num * 1.1);
                Console.WriteLine("ваш итоговый вклад равен " + num);
            }

        }
    }
}
