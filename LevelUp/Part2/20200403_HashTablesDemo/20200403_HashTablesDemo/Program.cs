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
            StringSet set1 = new StringSet();

            set1.Add("abcd");
            set1.Add("zzzzz");
            set1.Add("cbad");

            string key1 = "abcd";

            DoCheck(set1, key1);

            string key2 = "zzzzz";

            DoCheck(set1, key2);

            string key3 = "11111";

            DoCheck(set1, key3);

            string key4 = "cbad";

            DoCheck(set1, key4);

            Console.ReadKey();
        }

        private static void DoCheck(StringSet set, string key)
        {
            if (set[key])
            {
                Console.WriteLine("{0} in set", key);
            }
            else
            {
                Console.WriteLine("{0} not in set", key);
            }
        }
    }
}
