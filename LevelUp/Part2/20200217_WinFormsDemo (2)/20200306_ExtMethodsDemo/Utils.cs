using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200306_ExtMethodsDemo
{
    static class Utils
    {
        public static int GetSquare(this int arg)
        {
            return arg * arg;
        }

        public static IEnumerable GetDoubleSequance(this IEnumerable args)
        {
            int resulSize = 0;

            foreach (var item in args)
            {
                ++resulSize;
            }

            object[] result = new object[resulSize * 2];

            int index = 0;
            foreach (object item in args)
            {
                result[index++] = item;
                result[index++] = item;
            }

            return result;
        }
    }
}
