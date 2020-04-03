using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DividerLib;

namespace _20200208_ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = 10 / 0;

            // потенциально опасный код
            //int result = DoDiv(10, 0);

            try
            {                
                Divider.TestDivByZerro();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }      
    }
}
