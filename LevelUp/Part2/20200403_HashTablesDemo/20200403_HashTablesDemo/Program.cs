using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200403_HashTablesDemo
{
    class Program
    {       
        static void Main(string[] args)
        {
            StringSet set1 = new StringSet("set1"); // 100, 200, 300, 400, 500, 600, abcd, zzzzz, cbad

            StringSet set2 = new StringSet("set2");// 300, 400, 500, 600, 700, 800, 900, 1000

            FillData(set1, set2);

            Print(set1, set2);

            #region ExceptWith
            Console.WriteLine("" +
                "set1 ExceptWith set2 :");

            set1.ExceptWith(set2);
            set1.Print();
            #endregion

            #region IntersectWith
            FillData(set1, set2);

           //Print(set1, set2);

            Console.WriteLine("" +
                "set1 IntersectWith set2 :");

            set1.IntersectWith(set2);
            set1.Print();
            #endregion


            Console.ReadKey();

        }

        public static void Print(StringSet set1, StringSet set2)
        {
            set1.Print();
            set2.Print();
        }

        public static void FillData(StringSet set1, StringSet set2)
        {

            set1.RemoveAll();

            set2.RemoveAll();

            set1.Add("abcd");
            set1.Add("zzzzz");
            set1.Add("cbad");

            for (int i = 1; i <= 6; i++)
            {
                set1.Add((100*i).ToString());
            }

            for (int i = 3; i <= 10; i++)
            {
                set2.Add((100*i).ToString());
            }
        }
    }
}
