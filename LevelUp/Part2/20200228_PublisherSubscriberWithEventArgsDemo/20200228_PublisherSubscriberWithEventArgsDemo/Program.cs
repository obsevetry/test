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

            p.NextIter += NextIterationMainHandler;

            p.Run(10);

            Console.WriteLine();
            Console.WriteLine();

            p.NextIter += NextIterationMainHandler2;

            p.Run(10);

            #endregion

            Console.ReadKey();

            Console.Clear();


            Subscriber s7 = new Subscriber(7);

            p.NextIter += s7.NextIterationHandlerOne;    // p.Subscribe(s7.NextIterationHandlerOne);
            p.NextIter -= NextIterationMainHandler;    // p.Unsubscribe(NextIterationMainHandler);


            p.Run(10);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Call count = {0}", s7.CallCount);

            Console.ReadKey();

            Console.Clear();

            p.NextIter += s7.NextIterationHandlerTwo;    // p.Subscribe(s7.NextIterationHandlerTwo);
            p.NextIter -= NextIterationMainHandler2;    // p.Unsubscribe(NextIterationMainHandler2);

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

        private static void NextIterationMainHandler(object sender, NextIterationEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tProgram.NextIterationMainHandler({0})", args.Iteration);
        }

        private static void NextIterationMainHandler2(object sender, NextIterationEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tProgram.NextIterationMainHandler2({0})", args.Iteration);
        }
    }
}
