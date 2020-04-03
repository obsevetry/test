using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200306_StdDelegatesDemo
{
    static class Utils
    {
        public static bool MyTrueForAll(int[] source, MyPredicate p)
        {
            bool result = true;

            for (int i = 0; i < source.Length; i++)
            {
                if (!p(source[i]))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
