using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190823_1
{
    // Вводим n чисел. Вычислить макс. и мин. число
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для продолжения алгоритма введите целое число. Чтобы закончить цикл введите знак '='");
            int Max = 0;
            int Min = 0;
            bool isChoice = false;
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("Введите число № " + i.ToString());
                string input = Console.ReadLine();
                if (input == "=")
                {
                    break;
                }
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

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Для продолжения алгоритма введите целое число. Чтобы закончить цикл введите знак '='");
    //        int Max = 0;
    //        int Min = 0;
    //        bool isChoice = false;
    //        int i = 1;
    //            while (i>0)
    //        {
    //            Console.WriteLine("Введите число № " + i.ToString());
    //             i++;
    //            string input = Console.ReadLine();
    //            if (input == "=")
    //            {
    //                break;
    //            }
    //            int x = 0;
    //            bool result = int.TryParse(input, out x);
    //            if (result != true)
    //            {
    //                Console.WriteLine("Введены некорректные данные! Необходимо вводить только целые числа!");
    //                continue;
    //            }
    //            if (isChoice == false)
    //            {
    //                Max = x;
    //                Min = x;
    //                isChoice = true;
    //                continue;
    //            }
    //            if (x > Max)
    //            {
    //                Max = x;
    //            }
    //            if (x < Min)
    //            {
    //                Min = x;
    //            }
    //        }

    //        if (isChoice)
    //        {
    //            Console.WriteLine("Макс. число: {0}  Мин. число: {1}", Max, Min);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Введенные данные некорректны. Не удалось вычислить минимальное и максимальное число");
    //        }
    //        Console.ReadLine();
    //        Console.WriteLine();

    //    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Для продолжения алгоритма введите целое число. Чтобы закончить цикл введите знак '='");
    //        int Max = 0;
    //        int Min = 0;
    //        bool isChoice = false;
    //        int i = 1;
    //        do
    //        {
    //            Console.WriteLine("Введите число № " + i.ToString());
    //            i++;
    //            string input = Console.ReadLine();
    //            if (input == "=")
    //            {
    //                break;
    //            }
    //            int x = 0;
    //            bool result = int.TryParse(input, out x);
    //            if (result != true)
    //            {
    //                Console.WriteLine("Введены некорректные данные! Необходимо вводить только целые числа!");
    //                continue;
    //            }
    //            if (isChoice == false)
    //            {
    //                Max = x;
    //                Min = x;
    //                isChoice = true;
    //                continue;
    //            }
    //            if (x > Max)
    //            {
    //                Max = x;
    //            }
    //            if (x < Min)
    //            {
    //                Min = x;
    //            }
    //        }

    //        while (i > 0);

    //        if (isChoice)
    //        {
    //            Console.WriteLine("Макс. число: {0}  Мин. число: {1}", Max, Min);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Введенные данные некорректны. Не удалось вычислить минимальное и максимальное число");
    //        }
    //        Console.ReadLine();
    //        Console.WriteLine();

    //    }

    //}








}

