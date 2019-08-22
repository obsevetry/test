using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Вводим 5 чисел. Вычислить макс. и мин. число

namespace _20190818_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max = 0;
            int Min = 0;
            bool isChoice = false;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Введите число № " + i.ToString());
                string input = Console.ReadLine();
                int x = 0;
                bool result = int.TryParse(input, out x);
                if (result != true)
                {
                    Console.WriteLine("Введены некорректные данные! Необходимо вводить только целые числа!");
                    continue;
                }
                if (isChoice == false)
                {
                    Max = x;
                    Min = x;
                    isChoice = true;
                    continue;
                }       
                if (x > Max)
                {
                    Max = x;
                }
                if (x < Min)
                {
                    Min = x;
                }
            }
            
            if (isChoice)
            {
                Console.WriteLine("Макс. число: {0}  Мин. число: {1}", Max, Min);
            }
            else
            {
                Console.WriteLine("Введенные данные некорректны. Не удалось вычислить минимальное и максимальное число");
            }
            Console.ReadLine();
            Console.WriteLine();

        }
    }
}
