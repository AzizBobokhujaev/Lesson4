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
