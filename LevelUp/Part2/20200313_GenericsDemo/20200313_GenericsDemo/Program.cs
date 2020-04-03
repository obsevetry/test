using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200313_GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IntTest();

            DoubleTest();

            Console.ReadKey();
        }

        private static void IntTest()
        {
            int a = 10;
            int b = -10;

            int min1 = GetMin(a, b, 200, -200);

            Console.WriteLine("min1: {0}", min1);
        }

        private static void DoubleTest()
        {
            double a = 10.2;
            double b = -10.1;

            double min1 = GetMin(a, b);

            Console.WriteLine("min1: {0}", min1);
        }

        private static void IntDoubleTest()
        {
            double a = 10.2;
            int b = -10;

            //int min1 = GetMin(a, b);    // неявное преобразование: int ---> double
            double min1 = GetMin(a, b);

            Console.WriteLine("min1: {0}", min1);
        }

        public static T GetMin<T>(T arg1, T arg2)
        {
            T result = arg1;

            if (arg1 is IComparable<T>)
            {
                IComparable arg1Comp = (IComparable)arg1;

                if (arg1Comp.CompareTo(arg2) > 0)
                {
                    result = arg2;
                }
            }

            return result;
        }

        public static T GetMin<T>(T arg1, T arg2, T arg3)
        {
            T result = GetMin(arg1, arg2);

            return GetMin(result, arg3);
        }

        public static T GetMin<T>(params T[] args)
        {
            T result = GetMin(args[0], args[1]);

            for (int i = 2; i < args.Length; i++)
            {
                result = GetMin(result, args[i]);
            }

            return result;
        }
    }
}
