using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190916_4
{
    class Program
    {

        static void GetData(int counter, string strInput, string strSymbolSupport, string strNotSymbolSupport, out string strSymbol, out string strNotSymbol)
        {
            if (counter == strInput.Length)
            {
                strSymbol = strSymbolSupport;
                strNotSymbol = strNotSymbolSupport;
                return;
            }

            if (char.IsLetterOrDigit(strInput[counter]))
            {
                strSymbol = strSymbolSupport + strInput[counter].ToString();
                strNotSymbol = strNotSymbolSupport;
            }
            else
            {
                strSymbol = strSymbolSupport;
                strNotSymbol = strNotSymbolSupport + strInput[counter].ToString();
            }

            strSymbolSupport = strSymbol;
            strNotSymbolSupport = strNotSymbol;

            GetData(counter + 1, strInput, strSymbolSupport, strNotSymbolSupport, out strSymbol, out strNotSymbol);

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку:");

            string strInput = Console.ReadLine();

            string strSymbol = "";
            string strNotSymbol = "";

            string strSymbolSupport = "";
            string strNotSymbolSupport = "";

            int counter = 0;

            GetData(counter, strInput, strSymbolSupport, strNotSymbolSupport, out strSymbol, out strNotSymbol);

            Console.WriteLine("_______________________________________");
            Console.WriteLine("Строка символов {0}: ", strSymbol);
            Console.WriteLine("Строке НЕ символов {0}: ", strNotSymbol);

        }
    }
}
