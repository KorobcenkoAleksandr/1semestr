using System;

class PZ
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество участников: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Введите возраст участника {i + 1} (0-120): ");
                int age = int.Parse(Console.ReadLine());

                if (age >= 0 && age <= 120)
                {
                    a[i] = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: введенное значение должно быть от 0 до 120. Пожалуйста, попробуйте еще раз.");
                }
            }
        }
        double m = 0;
        for (int i = 0; i < n; i++)
        {
            m += a[i];
        }
        m /= n;
        int miAge = a[0];
        int maAge = a[0];

        for (int i = 1; i < n; i++)
        {
            if (a[i] < miAge)
            {
                miAge = a[i];
            }
            if (a[i] > maAge)
            {
                maAge = a[i];
            }
        }
        Console.WriteLine("Средний возраст: " + m);
        Console.WriteLine("Минимальный возраст: " + miAge);
        Console.WriteLine("Максимальный возраст: " + maAge);
    }
}
//ответ 1 : если нет предоствращение то программа просто произведёт вычисления но в данном случае выдаст ошибку
//ответ 2 : добавить условие с допустимым числовым диапазоном прим. if (age >= 0 && age <= 200)