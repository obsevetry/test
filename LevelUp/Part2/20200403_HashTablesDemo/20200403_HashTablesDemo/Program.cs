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

            StringSet setAll = new StringSet("setAll");// 300, 400, 500, 600, 700, 800, 900, 1000

            FillData(set1, set2, setAll);

            Print(set1, set2, setAll);

            #region ExceptWith
            Console.WriteLine("" +
                "set1 ExceptWith set2 :");

            set1.ExceptWith(set2);
            set1.Print();
            #endregion

            #region IntersectWith
            FillData(set1, set2, setAll);

            Console.WriteLine("" +
                "set1 IntersectWith set2 :");

            set1.IntersectWith(set2);
            set1.Print();
            #endregion

            #region IsProperSubsetOf
            FillData(set1, set2, setAll);

            Console.WriteLine("" +
                "set1 IsProperSubsetOf setAll : {0}", set1.IsProperSubsetOf(setAll));

            #endregion

            #region IsProperSubsetOf
            FillData(set1, set2, setAll);

            Console.WriteLine("" +
                "set1 IsProperSubsetOf setAll : {0}", set1.IsProperSupersetOf(setAll));

            #endregion

            #region SetEquals
            FillData(set1, set2, setAll);

            Console.WriteLine("" +
                "set1 SetEquals setAll : {0}", set1.SetEquals(setAll));

            #endregion

            #region Overlaps
            FillData(set1, set2, setAll);

            Console.WriteLine("" +
                "set1 Overlaps setAll : {0}", set1.Overlaps(setAll));

            #endregion

            #region SymmetricExceptWith
            FillData(set1, set2, setAll);

            set1.SymmetricExceptWith(set2);

            set1.Print();
            #endregion

            #region UnionWith
            FillData(set1, set2, setAll);

            set1.UnionWith(set2);

            set1.Print();
            #endregion


            Console.ReadKey();

        }

        public static void Print(StringSet set1, StringSet set2, StringSet setAll)
        {
            set1.Print();
            set2.Print();
            setAll.Print();
        }

        public static void FillData(StringSet set1, StringSet set2, StringSet setAll)
        {

            set1.RemoveAll();

            set2.RemoveAll();

            setAll.RemoveAll();

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
