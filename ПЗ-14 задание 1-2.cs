using System;
namespace циклы
{
    class Program
    {
        static double[] a = new double[1000];
        static void Main(string[] args)
        {
            int n = InputA();
            Console.WriteLine("сумма_For = {0}", sumF(n));
            Console.WriteLine("сумма_While = {0}", sumW(n));
            Console.WriteLine("сумма_DoWhile = {0}", sumD(n));
            Console.WriteLine("произведение_For = {0}", multyF(n));
            Console.WriteLine("произведение_While = {0}", multyW(n));
            Console.WriteLine("произведение_DoWhile = {0}", multyD(n));
            Console.ReadKey();
        }
        // Ввод размерности и массива
        static int InputA()
        {
            int n;
            Console.Write("Ввести кол-во элементов:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            return n;
        }
        // Сумма через цикл For
        static double sumF(int n)
        {
            double s = 0;
            
        for (int k = 0; k < n; k++)
                s = s + a[k];
            return s;
        }
        // Сумма через цикл While 
        static double sumW(int n)
        {
            double s = 0;
            int k = 0;
            while (k < n)
            {
                s = s + a[k];
                k++;
            }
            return s;
        }
        // Сумма через цикл Do-while 
        static double sumD(int n)
        {
            double s = 0;
            int k = 0;
            do
            {
                s = s + a[k];
                k++;
            } while (k <= n);
            return s;
        }
        // Произведение через цикл For 
        static double multyF(int n)
        {
            double p = 1;
            for (int k = 0; k < n; k++)
                p = p * a[k];
            return p;
        }
        // Произведение через цикл While 
        static double multyW(int n)
        {
            double p = 1;
            int k = 0;
            while (k < n)
            {
                
            p = p * a[k];
                k++;
            }
            return p;
        }
        // Произведение через цикл DoWhile
        static double multyD(int n)
        {
            double p = 1;
            int k = 0;
            do
            {
                p = p * a[k];
                k++;
            } while (k < n);
            return p;
        }
    }
}
//схожесть это само выражение сложения s=s+a[k]
//цикл for самый короткий ибо переменная и повторяемое простое действие записаны внутри цикла
//циклы while и DoWhile отличаются по большей части порядком написания условия (одно в начале другое в конце) т.к. по сути представляют одно и то-же просто иногда удобнее использовать 
//с умножением различий мало
//для простых лучше for
//для средних по объёму лучше while
//для больших лучше dowhile (он на самом деле позволяет чуть больше чем другие)
//читать проще всего while