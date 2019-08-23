using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190818_2
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int j = 0; j < 5; j++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                for (int i = 0; i < 100000000; i++)
                {
                    int p = i;
                }

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                Console.WriteLine("i++: {0}", elapsedMs);

                watch.Reset();
                watch.Start();

                for (int i = 0; i < 100000000; ++i)
                {
                    int p = i;
                }

                watch.Stop();
                elapsedMs = watch.ElapsedMilliseconds;
                Console.WriteLine("++i: {0}", elapsedMs);
                Console.WriteLine("__________________");
                Console.ReadKey();
            }

        }
    }
}
