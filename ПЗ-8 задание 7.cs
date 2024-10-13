using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пз_8
{
    internal class задание_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер операции:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            int num = (int)Convert.ToDouble(Console.ReadLine());
            if (num >=1 & num <=3)
            {
                string op ="";
                switch (num)
                {
                    case 1:
                        op = "сложение";
                        break;
                    case 2:
                        op = "вычитание";
                        break;
                    case 3:
                        op = "умножение";
                        break;
                }
                Console.WriteLine("Выбрана операция:" + op);
                Console.WriteLine("введите первое число");
                int num1 = (int)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите второе число");
                int num2 = (int)Convert.ToDouble(Console.ReadLine());
                int num3;
                if (op == "сложение")
                {
                    num3 = num1 + num2;
                    Console.WriteLine("ответ" + num3);
                }
                else if (op == "вычитание")
                {
                    num3 = num1 - num2;
                    Console.WriteLine("ответ" + num3);
                }
                else if (op == "умножение")
                {
                    num3 = num1 * num2;
                    Console.WriteLine("ответ " + num3);
                }

            }
            else
            {
                Console.WriteLine("операция не определена");
            }
        }
    }
}

