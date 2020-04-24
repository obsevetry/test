using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IReadOnlyList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add(i.ToString());
            }

            MyReadOnlyList roList = new MyReadOnlyList(myList);

            Print(roList, "Печать листа после создания");

            for (int i = 0; i < myList.Count; i++)
            {
                myList[i] = "123";
            }
            myList.Add("sdfsdf");

            Print(roList, "Печать листа после изменения элементов");

            Console.ReadKey();
        }

        private static void Print(MyReadOnlyList roList, string description)
        {
            Console.WriteLine(description);
            foreach (var item in roList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
