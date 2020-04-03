using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191207_BoxingUnboxingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IntStackDemo();

            Console.ForegroundColor = ConsoleColor.Red;

            DoubleStackDemo();

            Console.ReadKey();
        }

        private static void IntStackDemo()
        {
            Stack s = new Stack();
            s.Push(1);    // boxing
            s.Push(10);    // boxing
            s.Push(100);    // boxing
            s.Push(200);    // boxing
            s.Push(300);    // boxing

            while (!s.IsEmpty())
            {
                int v1 = (int)s.Pop();    // unboxing
                Console.WriteLine(v1);
            }

            //int v2 = (int)s.Pop();    // unboxing
            //Console.WriteLine(v2);

            //int v3 = (int)s.Pop();    // unboxing
            //Console.WriteLine(v3);
        }

        private static void DoubleStackDemo()
        {
            Stack s = new Stack();
            s.Push(11.1);    // boxing
            s.Push(12.56);    // boxing
            s.Push(1008.456);    // boxing

            double v1 = (double)s.Pop();    // unboxing
            Console.WriteLine(v1);

            //int v2 = (int)s.Pop();    // unboxing !!! отсуствие контроля типа данных!!!
            double v2 = (double)s.Pop();    // unboxing
            Console.WriteLine(v2);

            double v3 = (double)s.Pop();    // unboxing
            Console.WriteLine(v3);

            //double v4 = (double)s.Pop();    // unboxing
            //Console.WriteLine(v4);
        }
    }
}
