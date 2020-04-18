using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_MyHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleTable set1 = new SimpleTable("set1"); // 100, 200, 300, 400, 500, 600, abcd, zzzzz, cbad

            SimpleTable set2 = new SimpleTable("set2");// 300, 400, 500, 600, 700, 800, 900, 1000

            SimpleTable setAll = new SimpleTable("setAll");// 300, 400, 500, 600, 700, 800, 900, 1000

            FillData(set1, set2, setAll);

            Print(set1, set2, setAll);

            #region ExceptWith
            Console.WriteLine("" +
                "set1 ExceptWith set2 :");

            set1.ExceptWith(set2);
            Print(set1);
            #endregion

            #region IntersectWith
            FillData(set1, set2, setAll);

            Console.WriteLine("" +
                "set1 IntersectWith set2 :");

            set1.IntersectWith(set2);
            Print(set1);
            #endregion

            #region SymmetricExceptWith
            FillData(set1, set2, setAll);

            set1.SymmetricExceptWith(set2);

            Console.WriteLine("" +
                "set1 SymmetricExceptWith set2 :");
            Print(set1);
            #endregion

            Console.ReadKey();

        }

        public static void Print(SimpleTable set1, SimpleTable set2, SimpleTable setAll)
        {
            Print(set1);
            Print(set2);
            Print(setAll);
        }

        public static void Print(SimpleTable set)
        {
            Console.Write(set.Name + ": ");

            foreach (var item in set)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public static void FillData(SimpleTable set1, SimpleTable set2, SimpleTable setAll)
        {

            set1.Clear();

            set2.Clear();

            setAll.Clear();

            set1.Add("abcd");
            set1.Add("zzzzz");
            set1.Add("cbad");

            setAll.Add("abcd");
            setAll.Add("zzzzz");
            setAll.Add("cbad");

            for (int i = 1; i <= 6; i++)
            {
                string str = (100 * i).ToString();
                set1.Add(str);
                setAll.Add(str);
            }

            for (int i = 3; i <= 10; i++)
            {
                string str = (100 * i).ToString();
                set2.Add(str);
                setAll.Add(str);
            }
        }
    }
}
