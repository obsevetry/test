using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190830_1
{
    // Задача: сравнить две строки
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первую строку для сравнения");
            string firstSrting = Console.ReadLine();

            Console.WriteLine("Введите вторую строку для сравнения");
            string secondSrting = Console.ReadLine();

            string strResult = "Строки cовпадают";

            // Если длина строк отличается, дальше можно не проверять
            if (firstSrting.Length == secondSrting.Length)
            {
                for (int i = 0; i < firstSrting.Length; i++)
                {

                    if (firstSrting[i] != secondSrting[i])
                    {
                        strResult = "Строки НЕ cовпадают";
                        break;
                    }
                }
            }
            else
            {
                strResult = "Строки НЕ cовпадают";
            }

            Console.WriteLine("__________________");
            Console.WriteLine(strResult);
            Console.ReadKey();

        }
    }
}
