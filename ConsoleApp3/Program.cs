using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    
    
      
        public delegate double AverageDelegate(int m, int n);

        class Program
        {
            
            public static double Average(int m, int n)
            {
                if (m > n)
                {
                    Console.WriteLine("Ошибка: начальное число больше конечного.");
                    return 0;
                }

                double sum = 0;
                int count = 0;

              
                for (int i = m; i <= n; i++)
                {
                    sum += i;
                    count++;
                }

              
                return sum / count;
            }

            static void Main(string[] args)
            {
               
                AverageDelegate averageDelegate = new AverageDelegate(Average);
                Console.WriteLine($"Среднее арифметическое от 1 до 10: {averageDelegate(1, 10)}");
                Console.WriteLine($"Среднее арифметическое от 5 до 15: {averageDelegate(5, 15)}");
                Console.WriteLine($"Среднее арифметическое от 10 до 20: {averageDelegate(10, 20)}");
                Console.ReadLine();
            }
        }
}

