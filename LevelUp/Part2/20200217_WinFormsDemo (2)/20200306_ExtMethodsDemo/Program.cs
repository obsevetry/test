using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200306_ExtMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            int res1 = Utils.GetSquare(a);

            Console.WriteLine("res1 = {0}", res1);

            int res2 = a.GetSquare().GetSquare();

            Console.WriteLine("res2 = {0}", res2);

            // ------------------------------------------

            Console.ForegroundColor = ConsoleColor.Green;

            int[] source = new int[] { 200, -2, 90, -756 };

            foreach (var item in source.GetDoubleSequance())
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            IEnumerable seq1 = source.GetDoubleSequance();
            IEnumerable seq2 = seq1.GetDoubleSequance();
            IEnumerable seq3 = seq2.GetDoubleSequance();

            foreach (var item in seq3 /*source.GetDoubleSequance().GetDoubleSequance().GetDoubleSequance()*/)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
