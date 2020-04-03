using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200221_PublisherSubscriberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();

            p.Run(10);

            Console.WriteLine();
            Console.WriteLine();

            #region Подписка статическими методами

            p.Subscribe(NextIterationMainHandler);

            p.Run(10);

            Console.WriteLine();
            Console.WriteLine();

            p.Subscribe(NextIterationMainHandler2);

            p.Run(10);

            #endregion

            Console.ReadKey();

            Console.Clear();


            Subscriber s7 = new Subscriber(7);

            p.Subscribe(s7.NextIterationHandlerOne);
            p.Unsubscribe(NextIterationMainHandler);

            p.Run(10);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Call count = {0}", s7.CallCount);

            Console.ReadKey();

            Console.Clear();            

            p.Subscribe(s7.NextIterationHandlerTwo);
            p.Unsubscribe(NextIterationMainHandler2);

            p.Run(10);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Call count = {0}", s7.CallCount);

            Console.ReadKey();

            Console.Clear();

            IncapsulateSubscriber incs8 = new IncapsulateSubscriber(8, p);

            p.Run(10);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Call count (s7) = {0}", s7.CallCount);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Call count (incs8) = {0}", incs8.CallCount);

            Console.ReadKey();
        }

        private static void NextIterationMainHandler(int index)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tProgram.NextIterationMainHandler({0})", index);
        }

        private static void NextIterationMainHandler2(int index)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tProgram.NextIterationMainHandler2({0})", index);
        }
    }
}
