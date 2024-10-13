using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пз_8
{
        internal class задание6
        {
            static void ain(string[] args)
            {
                Console.WriteLine("Введите номер операции:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
            int num = (int)Convert.ToDouble(Console.ReadLine());
            if (num <= 1 & num <= 3)
            {
                    string op;
                    switch (num)
                    {
                        case 1:
                            op = "Сложение";
                            break;
                        case 2:
                            op = "Вычитание";
                            break;
                        case 3:
                            op = "Умножение";
                            break;
                        default:
                            op = "Операция неопределена";
                            break;
                    }
                    Console.WriteLine($"Выбрана операция:" + op);
                }
                else
                {
                    Console.WriteLine("операция не определена");
                }
            }
        }
    }