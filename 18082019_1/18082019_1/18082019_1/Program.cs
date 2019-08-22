using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18082019_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int Max = 0;
            int Min = 0;
            bool isChoice = false;//
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

            Console.WriteLine("Макс. число: {0}  Мин. число: {1}", Max, Min);
            Console.ReadLine();
            Console.WriteLine();

        }
    }
}
