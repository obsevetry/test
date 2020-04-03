using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200306_StdDelegatesDemo
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 2, -4, 2, 78, -4, -567 };

            Array.Sort(arr1);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("arr1:");
            foreach (int item in arr1)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Array.Sort(arr1, MyCompare);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("arr1(reverse):");
            foreach (int item in arr1)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;

            bool existedPosiveElements1 = Array.TrueForAll(arr1, IsPositive);

            Console.WriteLine("existedPosiveElement1 = {0}", existedPosiveElements1);

            int[] arr2 = new int[] { 2, 4, -78, 567 };

            //Array.Sort(arr);

            bool existedPosiveElements2 = Array.TrueForAll(arr2, IsPositive);

            Console.WriteLine("existedPosiveElements2 = {0}", existedPosiveElements2);

            bool isAllPosiveElements = Utils.MyTrueForAll(arr2, IsPositive);

            Console.WriteLine("isAllPosiveElements = {0}", isAllPosiveElements);

            Console.WriteLine("Array.Find() demo");

            int[] arr3 = new int[] { -2, 4, -78, 3, 4, 567, 5 };

            bool existedPositive = Array.Exists(arr3, IsPositive);

            Console.WriteLine("existedPositive = {0}", existedPositive);

            bool existedInRange36 = Array.Exists(arr3, InRange);

            Console.WriteLine("existedInRange36 = {0}", existedInRange36);

            int indexInRange36 = Array.FindIndex(arr3, InRange);

            Console.WriteLine("indexInRange36 = {0}", indexInRange36);

            int[] itemsInRange36 = Array.FindAll(arr3, InRange);

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (int item in itemsInRange36)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Array.ForEach(itemsInRange36, Print);

            Console.ReadKey();
        }

        #region ---===   Predicate delegate demo   ===---

        public static bool IsPositive(int item)
        {

            bool result = false;

            if (item > 0)
            {
                result = true;
            }

            Console.WriteLine("{0}: {1}", item, result);

            return result;
        }

        public static bool InRange(int item)
        {

            bool result = false;

            if (item >= 3 && item <= 6)
            {
                result = true;
            }

            Console.WriteLine("{0}: {1}", item, result);

            return result;
        }

        #endregion

        #region ---===  Action delegate demo   === ---

        public static void Print(int val)
        {
            Console.Write("{0} ", val);
        }

        #endregion

        #region ---===   Comparison   ===---

        public static int MyCompare(int arg1, int arg2)
        {
            //int result = 0;

            //if (arg1 > arg2)
            //{
            //    result = -1;
            //}
            //else
            //{
            //    if (arg1 < arg2)
            //    {
            //        result = 1;
            //    }
            //}

            //return result;

            return -arg1.CompareTo(arg2);
        }

        #endregion
    }
}
