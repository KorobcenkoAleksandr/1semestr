public class Program
{
static void Main(string[] args)
    {
        Console.WriteLine("введите номер задания (1-22");
        string command = Console.ReadLine();

        switch (command)
        {
            default:
                Console.WriteLine("неверная комманда");
                break;

            case "1":
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine(j);
                }
                break;

            case "2":
                Console.WriteLine("введите n (>0)");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int j1 = 0; j1 <= n; j1++)
                {
                    Console.WriteLine(j1);
                }
                break;

            case "3":
                Console.WriteLine("введите n (>0)");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int j2 = 0;
                while (j2 <= n1)
                    j2++;
                if (j2 % 2 != 0)
                {
                    Console.WriteLine(j2);
                }
                break;

            case "4":
                int n2 = 0;
                int j3 = Convert.ToInt32(Console.ReadLine()); ;
                while (j3 <= n2)
                    j3++;
                {
                    if (j3 % 2 == 0)
                    {
                        Console.WriteLine(j3);
                    }
                }
                break;

            case "5":
                int n3 = 0;
                int j4 = Convert.ToInt32(Console.ReadLine()); ;
                while (j4 <= n3)
                    j4++;
                {
                    if (j4 % 3 == 0)
                    {
                        Console.WriteLine(j4);
                    }
                }
                break;

            case "6":
                Console.Write("Введите значение n: ");
                int n4 = Convert.ToInt32(Console.ReadLine()); ;

                for (int j5 = 0; j5 <= n4; j5++)
                {
                    if (j5 % 3 == 0 || j5 % 7 == 0)
                    {
                        Console.WriteLine(j5);
                    }
                }
                        break;
                        case "7":
                Console.Write("Введите значение n: ");
                int n5 = Convert.ToInt32(Console.ReadLine()); ;
                long sum = 0;
                for (int j6 = 1; j6 <= n5; j6++)
                {
                    sum += j6;
                }
                Console.WriteLine(sum);
                break;

                        case "8":
                Console.Write("Введите значение n: ");
                int n6 = Convert.ToInt32(Console.ReadLine()); ;
                long sum1 = 0;
                for (int j7 = 1; j7 <= n6; j7++)
                {
                    if (j7 % 2 == 0)
                    {
                        sum1 += j7;
                    }
                }
                Console.WriteLine(sum1);
                break;

                        case "9":
                long sum2 = 0;
                long sum3 = 0;
                long sum4 = 0;
                long j8a = 0;
                long j8b = 0;
                Console.Write("Введите значение a: (a<b)");
                int a = Convert.ToInt32(Console.ReadLine()); ;
                Console.Write("Введите значение b: (a<b) ,ваше значение а:",a);
                int b = Convert.ToInt32(Console.ReadLine()); ;
                while (j8a <= a) ;
                {
                    j8a++;
                }
                while(j8b <= b) ;
                {
                    j8b++;
                }
                sum2 += j8a;
                sum3 += j8b;
                sum4 = sum2+sum3;
                Console.WriteLine(sum4);
                break;

                        case "10":
                long sum5 = 0;
                Console.Write("Введите значение n: ");
                int n7 = Convert.ToInt32(Console.ReadLine()); ;

                for (int j9 = 0; j9 <= n7; j9++)
                {
                    if (j9 % 3 == 0)
                    {
                        sum5 += j9;
                    }
                    Console.WriteLine(sum5);
                }
                break;

                        case "11":
                Console.Write("Введите значение n: (n>0)");
                int n8 = Convert.ToInt32(Console.ReadLine());
                double sum6 = 0;
                for (int j10 = 1; j10 <= n8; j10++) //после перейду на переменную i
                {
                    sum6 += 1.0 / j10;
                }
                Console.WriteLine(sum6);
                break;

                        case "12":
                Console.Write("Введите значение n: ");
                int n9 = Convert.ToInt32(Console.ReadLine());
                long sum7 = 0;
                long st2 = 1; //степенные
                for (int i = 0; i <= n9; i++)
                {
                    sum7 += st2;
                    st2 *= 2;
                }
                Console.WriteLine(st2);
                break;

                        case "13":
                static int FindGCD(int a, int b)
                {
                    if (b == 0)
                    {
                        return a;
                    }
                    else
                    {
                        return FindGCD(b, a % b);
                    }
                }
                Console.Write("Введите число A: ");
                int a2 = int.Parse(Console.ReadLine());

                Console.Write("Введите число B: ");
                int b2 = int.Parse(Console.ReadLine());
                int gcd = FindGCD(a2, b2);
                Console.WriteLine($"Наибольший общий делитель (НОД) чисел {a2} и {b2}: {gcd}");
                break;

                        case "14":
                Console.Write("Введите процент увеличения пробега (P, 0 < P < 50): ");
                double p = double.Parse(Console.ReadLine());
                double distance = 10;
                double totalDistance = 10;
                int days = 1;

                while (totalDistance <= 200)
                {
                    distance *= (1 + p / 100);
                    totalDistance += distance;
                    days++;
                }

                Console.WriteLine("Суммарный пробег превысил 200 км после дней.",days);
                Console.WriteLine("Суммарный пробег:км",totalDistance);
                break;

                        case "15":
                Console.Write("Введите число N: ");
                int n10 = int.Parse(Console.ReadLine());

                if (n10<0)
                {
                    Console.WriteLine("FALSE");
                }
                else if (n10 == 0 || n10 == 1)
                {
                    Console.WriteLine("TRUE");
                }
                int a3 = 1;
                int b3 = 1;
                int c;

                while (b3 < n10)
                {
                    c = a3 + b3;
                    a3 = b3;
                    b3 = c;
                }
                if( b3 == n10);
                {
                    Console.WriteLine("TRUE");
                }
                
                break;

                        case "16":
                Console.Write("Введите длину прямоугольника A: ");
                int a4 = int.Parse(Console.ReadLine());
                Console.Write("Введите ширину прямоугольника B: ");
                int b4 = int.Parse(Console.ReadLine());
                Console.Write("Введите сторону квадрата C: ");
                int c4 = int.Parse(Console.ReadLine());
                

                int count = 0;
                int remainingA = a4;
                int remainingB = b4;

                while (remainingA >= c4 && remainingB >= c4)
                {
                    count++;
                    remainingA -= c4;
                    remainingB -= c4;
                }
                 Console.WriteLine($"Количество квадратов: {count}");
                break;

            case "17":
                Console.Write("Введите число Фибоначчи N: ");
                long n11 = long.Parse(Console.ReadLine());
                long a5 = 1;
                long b5 = 1;
                int k = 2;

                while (b5 < n11)
                {
                    long temp = a5 + b5;
                    a = (int)b5;
                    b = (int)temp;
                    k++;
                }
                Console.WriteLine("номер числа фибоначи",k);
                break;

                        case "18":
                Console.Write("Введите значение n: ");
                int n12 = int.Parse(Console.ReadLine());
                double sum8 = 0;
                for (int i1 = 1; i1 <= n12; i1++)
                {
                    sum8 += 1.0 + 0.1 * i1;
                }
                Console.WriteLine(sum8);
                break;

                        case "19":
                Console.WriteLine("Введите значение n: ");
                int n13 = int.Parse(Console.ReadLine());
                double sum9 = 0;
                double sign = 1;

                for (int i2 = 1; i2 <= n13; i2++)
                {
                    sum9 += sign * (1.0 + (double)i2 / 10);
                    sign *= -1;
                }
                    break;

                        case "20":
                Console.Write("Введите целое неотрицательное число n: ");
                int n14 = int.Parse(Console.ReadLine());
                long sum10 = 0; // Используем long для больших чисел
                

                for (int i3 = 1; i3 <= 2 * n14 - 1; i3 += 2)
                {
                    sum10 += i3;
                    Console.Write($"{i3} ");
                    if (i3 < 2 * n14 - 1) Console.Write("+ "); // Не добавляем "+" после последнего слагаемого

                }

                Console.WriteLine(sum10);
                Console.Write($"Квадрат числа {n14} равен: ");
                break;

                        case "21":
                Console.Write("Введите вещественное число A: ");
                double a6 = double.Parse(Console.ReadLine());
                Console.Write("Введите целое число N (N > 0): ");
                int n15 = int.Parse(Console.ReadLine());
                double result = 1;
                for (int i4 = 0; i4 < n15; i4++)
                {
                    result *= a6;
                }
                Console.WriteLine(result);
                break;

                        case "22":
                Console.Write("Введите число K (1 ≤ K ≤ 100000): ");
                int k2 = int.Parse(Console.ReadLine());
                static bool IsPalindrome(int n)
                {
                    string s = n.ToString();
                    string reversed = new string(s.Reverse().ToArray());
                    return s == reversed;
                }
                int count2 = 0;
                for (int i = 1; i <= k2; i++)
                {
                    if (IsPalindrome(i))
                    {
                        count2++;
                    }
                }
                Console.WriteLine(count2);
                break;
                        }
                    }
                }
        