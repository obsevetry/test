using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18082019_1
{
    class Program
    {
        // Вводим 5 чисел. Вычислить макс. и мин. число
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
                if (result == true)
                {
                    if (isChoice == false)
                    {
                        Max = x;
                        Min = x;
                    }
                    isChoice = true;
                    if (x >= Max)
                    {
                        Max = x;
                    }
                    if (x < Min)
                    {
                        Min = x;
                    }
                }
                else
                {
                    Console.WriteLine("Введены некорректные данные!. Необходимо вводить только числа!");
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
