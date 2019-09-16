using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190916_1
{
    class Program
    {
        public static int GetFactorial(int n)
        {

            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * GetFactorial(n - 1);
            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите число, для которого необходимо посчитать факториал:");
            string input = Console.ReadLine();

            int n = 0;
       
            string strError = "";
            bool isError = !input.All(char.IsDigit);

            if (isError)
            {
                strError = "Введено некорректное число !";
            }

            int.TryParse(input, out n);

            int rezFactorial = 0;

            if (n < 0) 
            {
                strError = "Введено отрицательное число !";
                isError = true;
            }
            else
            {
                rezFactorial = GetFactorial(n);
            }

            Console.WriteLine("_______________________________");
            if (isError)
            {
                Console.WriteLine(strError);   
            }
            else
            {
                Console.WriteLine("Факториал числа {0} равен {1}", input, rezFactorial);
            }

        }
    }
}
