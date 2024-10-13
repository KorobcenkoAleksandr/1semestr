using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class programm
    {
        static void Main(string[] args)
        {
            string s1 = "я скоро поеду на научную конференцию в курск"; //индекс
            string subString = "курск";
            int indexOfSubString = s1.IndexOf(subString);
            Console.WriteLine("индекс слова курск равен ", indexOfSubString);

            string textr = s1; //убрать в курск
            textr = textr.Remove(0, 7);
            Console.WriteLine(textr);

            string textz = s1; //замена
            textz = textz.Replace("научную конференцию", "соревновения");
            Console.WriteLine(textz);

            Console.WriteLine(s1.ToUpper()); //верхний регистр
        }
    }
}
