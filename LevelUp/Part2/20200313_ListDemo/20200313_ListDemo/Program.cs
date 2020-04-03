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
            SingleLinkedList<string> l1 = new SingleLinkedList<string>();

            l1.AddToBegin("abc");

            l1.Print();

            l1.AddToBegin("zzzz");

            l1.Print();

            l1.AddToBegin("khjhjgh");

            l1.Print();

            Console.ReadKey();
        }
    }
}
