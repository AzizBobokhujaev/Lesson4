using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("----------HomeWork_2----------");
            System.Console.WriteLine("Введите значение А и В (А<B)");
            int A,B,Sum;
            Console.Write("A = ");A=Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");B=Convert.ToInt32(Console.ReadLine());
            if (!(A<B))
            {
                Console.WriteLine("А должно быть меньше чем В");
                Environment.Exit(0);
            }
            Sum=0;
            for (int i = A; i <= B; i++)
            {
                
                if (i%2==1)
                {
                    Console.Write(i+" ");
                }else{
                    Sum+=i;                    
                }                   
                
            }
            Console.WriteLine();
            Console.WriteLine("SUM = "+Sum);
            System.Console.WriteLine("----------HomeWork_3----------");
            Console.WriteLine("Прямоугольник:");
            for (int i = 0; i < 5; i++)
            {                
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Прямоугольный треугольник");
            for (int i = 0; i < 5; i++)
            {                
                for (int j = 0; j < 5; j++)
                {
                    if (j<=i)
                    {
                        Console.Write("* ");                      
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Равносторонний треугольник ");
            int k = int.Parse(Console.ReadLine());
            int n = k - 1;
            int x = 2 * (k - 1) + 1;
            for (int p = 0; p <= n; p++)
            {
                for (int j = k - 1; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i <= (x - 2 * (k - 1)); i++)
                {
                    if ((i % 2 == 1 && i == 1) || (i % 2 == 1 && i == (x - 2 * (k - 1))) || (i % 2 == 1 && p == n))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                k--;
            }
            Console.WriteLine("Ромб");
            int h, h1, h2, h3, h4;
            int s;
            h = Int32.Parse(Console.ReadLine());

            h /= 2;

            h1 = h - (h - 1);
            h2 = h;
            h3 = h - (h - 1);
            h4 = 2 * h;

            s = h;
            if (s == h) { h++; }

            for (int c1 = 0; c1 < h; c1++, h2--, h1 += 2)
            {
               for (int c2 = 0; c2 < h2; c2++)
               { Console.Write(" "); }
               for (int c3 = 0; c3 < h1; c3++)
               { Console.Write("*"); }
               Console.WriteLine();
            }
            for (int c4 = 0; c4 < h; c4++, h3++, h4 -= 2)
            {
               for (int c5 = 0; c5 < h3; c5++)
               {
                   Console.Write(" ");
               }
               for (int c6 = 0; c6 < h4 - 1; c6++)
               {
                   Console.Write("*");
               }
               Console.WriteLine();
            }
            System.Console.WriteLine("----------HomeWork_4----------");
            double percent,deposit;
            int month;
            deposit = 1000;
            month =0;
            Console.Write("Введите процент по вкладу(0<percent<25) :");percent = Convert.ToDouble(Console.ReadLine());
            if (percent < 0 || percent > 25)
            {
                Console.WriteLine("Неверный процент");
                Environment.Exit(0);
                
            }
            while (deposit < 1100)
            {
                deposit += deposit * percent / 100;
                month++;
            }
            Console.WriteLine($"Размер вклада превысит 1100р через: {month} месяца ");
            Console.WriteLine($"Сумма = {deposit}");

        }   
    }
}
