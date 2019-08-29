using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190830_2
{

    // Задача: проверить на палиндром
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку для проверки на палиндром:");
            string firstSrting = Console.ReadLine();

            // Уберем пробелы
            firstSrting = firstSrting.Replace(" ", "");
            firstSrting = firstSrting.ToUpper();

            // Уберем символы
            for (int i = 0; i < firstSrting.Length; i++)
            {
                if (!char.IsLetterOrDigit(firstSrting[i]))
                {
                    firstSrting = firstSrting.Replace(firstSrting[i].ToString(), "");
                }
            }

            string strReverse = "";
            // Формируем строку реверс
            for (int i = firstSrting.Length - 1; i >= 0; i--)
            {
                strReverse += firstSrting[i];
            }

            string strResult = "Это НЕ палиндром";
            if (firstSrting == strReverse && firstSrting.Length > 0)
            {
                strResult = "Это палиндром";
            }

            Console.WriteLine("__________________");
            Console.WriteLine(strResult);
            Console.ReadKey();
        }
    }
}
