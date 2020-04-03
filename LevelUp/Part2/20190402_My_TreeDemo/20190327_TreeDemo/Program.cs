using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190327_TreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<double, string> t1 = new Tree<double, string>();

            t1.Add(2.1);
            t1.Add(-1.1);
            t1.Add(2.3);

            t1.Add(2.1);
            t1.Add(10.0);
            t1.Add(10.0);
            t1.Add(-10.0);
            t1.Add(-0.5);

            Console.WriteLine("t1: ");
            Console.WriteLine(t1);

            Console.ReadKey();
        }
    }
}
