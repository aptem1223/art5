using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void GreetingDelegate();

    class Program
    {
        public static void GoodMorning()
        {
            Console.WriteLine("Доброе утро!");
        }

        public static void GoodEvening()
        {
            Console.WriteLine("Добрый вечер!");
        }

        static void Main(string[] args)
        {
            // 3. Создание делегатов
            GreetingDelegate morningGreeting = new GreetingDelegate(GoodMorning);
            GreetingDelegate eveningGreeting = new GreetingDelegate(GoodEvening);

            // Определяем текущее время
            DateTime currentTime = DateTime.Now;

            // 4. Применение делегата в зависимости от времени суток
            if (currentTime.Hour < 12)
            {
                // Если утро (с 00:00 до 11:59)
                morningGreeting();
            }
            else
            {
                // Если вечер (с 12:00 до 23:59)
                eveningGreeting();
            }

            Console.ReadLine(); // Чтобы консоль не закрывалась сразу
        }
    }

}
