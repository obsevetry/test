using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191214_OperatorsOverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyInt arg1 = new MyInt(3);
            MyInt arg2 = new MyInt(5);

            MyInt res1 = MyInt.Add(arg1, arg2);

            Console.WriteLine("res1 = {0}", res1.Val);

            MyInt res2 = arg1 + arg2;

            Console.WriteLine("res2 = {0}", res2.Val);

            MyInt res3 = arg2 - arg1;

            Console.WriteLine("res3 = {0}", res3.Val);

            MyInt res4 = arg2 - 4;

            Console.WriteLine("res4 = {0}", res4.Val);

            MyInt res5 = 14 - arg2;

            Console.WriteLine("res5 = {0}", res5.Val);

            if (res1 == res2)
            {
                Console.WriteLine("==");
            }
            else
            {
                Console.WriteLine("!=");
            }

            if (res2 != res3)
            {
                Console.WriteLine("res2 != res3");
            }
            else
            {
                Console.WriteLine("res2 == res3");
            }

            if (res2 < res3)
            {
                Console.WriteLine("res2 < res3");
            }
            else
            {
                Console.WriteLine("res2 >= res3");
            }

            if (res2 <= res3)
            {
                Console.WriteLine("res2 <= res3");
            }
            else
            {
                Console.WriteLine("res2 > res3");
            }

            MyInt resCopyPost = res2++;
            Console.WriteLine("res2 = {0}", res2.Val);
            Console.WriteLine("resCopyPost = {0}", resCopyPost.Val);

            MyInt resCopyPref = ++res2;
            Console.WriteLine("res2 = {0}", res2.Val);
            Console.WriteLine("resCopyPref = {0}", resCopyPref.Val);

            MyInt test1 = new MyInt(0xFF000F);
            MyInt test2 = new MyInt(0xFF000F);
            MyInt test3 = new MyInt(0xF0FFF0);

            MyInt resTest1 = test1 ^ test2;
            Console.WriteLine("resTest1 = {0:X}", resTest1.Val);

            MyInt resTest2 = test1 ^ test3;
            Console.WriteLine("resTest2 = {0:X}", resTest2.Val);

            //int t2 = (int)resTest2;    // явное преобразование типа данных
            int t2 = (int)resTest2;    // явное преобразование типа данных

            float t3 = (float)resTest2;    // неявное преобразование типа данных

            double t4 = resTest2;    // неявное преобразование типа данных

            if (test3)
            {
                Console.WriteLine("test3: true");
            }
            else
            {
                Console.WriteLine("test3: false");
            }

            MyInt test5 = new MyInt(0);

            if (test5)
            {
                Console.WriteLine("test5: true");
            }
            else
            {
                Console.WriteLine("test5: false");
            }

            Console.ReadKey();
        }
    }
}
