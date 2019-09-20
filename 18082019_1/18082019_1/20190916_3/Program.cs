using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190916_3
{
    class Program
    {

        public static void GetMinMaxNumber(int counter, int maxNumberSupport, int minNumberSupport, out int maxNumber, out int minNumber)
        {

            if (counter == 0)
            {
                maxNumber = maxNumberSupport;
                minNumber = minNumberSupport;
                return;
            }
            else
            {
                string Result = Console.ReadLine();

                if (Result == "=")
                {
                    maxNumber = maxNumberSupport;
                    minNumber = minNumberSupport;
                    return;
                }

                int currentNumber = 0;

                int.TryParse(Result, out currentNumber);

                int currentMax = 0;

                if (currentNumber > maxNumberSupport)
                {
                    currentMax = currentNumber;
                }
                else
                {
                    currentMax = maxNumberSupport;
                }

                int currentMin = 0;

                if (currentNumber < minNumberSupport)
                {
                    currentMin = currentNumber;
                }
                else
                {
                    currentMin = minNumberSupport;
                }

                maxNumber = currentMax;
                minNumber = currentMin;

                GetMinMaxNumber(counter - 1, currentMax, currentMin, out maxNumber, out minNumber);
            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество вводимых чисел (или чтобы закончить цикл введите знак '='):");

            int counter = 0;

            if (int.TryParse(Console.ReadLine(), out counter) != true)
            {
                Console.WriteLine("Введены некорректные данные! Необходимо вводить только целые числа!");
            }

            int maxNumber = 0;
            int minNumber = 0;

            int maxNumberSupport = int.MinValue;
            int minNumberSupport = int.MaxValue;

            GetMinMaxNumber(counter, maxNumberSupport, minNumberSupport, out maxNumber, out minNumber);

            Console.WriteLine("_______________________________________");
            Console.WriteLine("Минимальное число {0}", minNumber);
            Console.WriteLine("Максимальное число {0}", maxNumber);


        }
    }
}
