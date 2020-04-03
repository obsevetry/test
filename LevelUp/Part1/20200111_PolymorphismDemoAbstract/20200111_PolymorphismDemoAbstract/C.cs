using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191221_PolymorphismDemo
{
    class C : B
    {
        public C()
        {
            ++_val;
        }

        public void F()
        {
            Console.WriteLine("C.F()");
        }

        public /*sealed*/ override void FVirt()
        {
            Console.WriteLine("C.FVirt(): _val = {0}", _val);
        }
    }
}
