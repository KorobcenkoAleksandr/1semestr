using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare
{
    class Programm
    {
        static void Main(string[] args)
        {
            {
                ConcatString();
                Joinstring();
                CompareHalloWorld();
                FindInString();
                InsertString();
                DeleteString();
                ReplaceString();
                UpperLowerString();
            }
            static void ConcatString()
            {
                String s1 = "привет ";
                string s2 = "мир!";
                string s3 = s1 + "" + s2;
                string s4 = string.Concat(s3, "!!!");
                Console.WriteLine(s4);
            }
            static void Joinstring()
            {
                string s5 = "каждый";
                string s6 = "охотник";
                string s7 = "желает";
                string s8 = "знать";
                string s9 = "где сидит";
                string s10 = "фазан";
                string[] values = new string[](s5, s6, s7, s8, s9, s10);
                string s11 = string.Join("", values);
                Console.WriteLine(s11);
            }
            static void CompareHalloWorld()
            {
                string s1 = "привет ";
                string s2 = "мир!";
                int result = String.Compare(s1, s2);
                if (result < 0)
                {
                    Console.WriteLine("строка s1 перед строкой s2");
                }
                else if (result > 0)
                {
                    Console.WriteLine("строка s1 стоит после строки s2");
                }
                else
                {
                    Console.WriteLine("строки s1 и s2 идентичны");
                }
            }
            static void FindInString()
            {
                string s1 = "привет , мир!";
                char ch = 'т';
                int indexofxhar = s1.IndexOf(ch);
                Console.WriteLine("индекс в строке символа {0} - {1}", ch, indexofxhar);

                string subString = "рив";
                int indexOfSubString = s1.IndexOf(subString);
                Console.WriteLine("индекс подстроки в строке {0} - {1}", subString, indexOfSubString);
            }
            static void InsertString()
            {
                string text = "задание выполнено";
                string subString = "не ";
                text = text.Insert(8, subString);
                Console.WriteLine(text);
            }
            static void DeleteString()
            {
                string text = "задание выполнено";
                int ind = text.Length - 1;
                text = text.Remove(ind);
                Console.WriteLine(text);
                text = text.Remove(0, 2);
            }
            static void ReplaceString()
            {
                string text = "солнечное утро";
                text = text.Replace("солнечное", "дождливое");
                Console.WriteLine(text);
            }
            static void UpperLowerString()
            {
                String Hello = "привет мир!";
                Console.WriteLine(Hello.ToLower());
                Console.WriteLine(Hello.ToUpper());
            }
        }
    }
}
