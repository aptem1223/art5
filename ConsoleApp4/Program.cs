using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

        public delegate int SumDelegate(int m, int n);

        class Program
        {
            
            public static int Sum(int m, int n)
            {
                int sum = 0;
                for (int i = m; i <= n; i++)
                {
                    sum += i;
                }
                return sum;
            }
            static void Main(string[] args)
            {
                
                SumDelegate sumDelegate = new SumDelegate(Sum);
                Console.WriteLine($"Сумма от 1 до 10: {sumDelegate(1, 10)}");
                Console.WriteLine($"Сумма от 5 до 15: {sumDelegate(5, 15)}");
                Console.WriteLine($"Сумма от 10 до 20: {sumDelegate(10, 20)}");
                Console.ReadLine();
            }
        }
    

}
