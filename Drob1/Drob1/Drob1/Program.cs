using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drob1
{
    class Program
    {
        static void Main(string[] args)
        {

            Drob A = new Drob(1, 5);
            Drob B = new Drob(1, 5);
            Console.WriteLine((A + B).ToString());
            Console.ReadLine();

        }
    }
}
