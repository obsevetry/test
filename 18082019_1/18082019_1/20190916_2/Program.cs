using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190916_2
{
    class Program
    {

        static string GetRevers(int i, string firstSrting)
        {
            if (i < 0)
            {
                return "";
            }

            return firstSrting[i] + GetRevers(i - 1, firstSrting);
        }

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

            // Формируем строку реверс
            string strReverse = GetRevers(firstSrting.Length - 1, firstSrting);

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
