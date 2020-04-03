using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200313_ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTestList(new SingleLinkedList<string>());

            Console.WriteLine();
            Console.WriteLine();

            DoTestList(new DoubleLinkedList<string>());

            Console.ReadKey();
        }

        private static void DoTestList(ILinkedList<string> l1)
        {
            l1.AddToBegin("abc");

            l1.Print();
            Console.WriteLine();

            l1.AddToBegin("zzzz");

            l1.Print();
            Console.WriteLine();

            l1.AddToBegin("khjhjgh");

            l1.Print();
            Console.WriteLine();
        }
    }
}
