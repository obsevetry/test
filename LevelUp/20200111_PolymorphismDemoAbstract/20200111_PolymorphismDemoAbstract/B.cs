using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191221_PolymorphismDemo
{
    class B : A
    {
        public B()
        {
            ++_val;
        }

        public void F()
        {
            Console.WriteLine("B.F()");
        }

        //public new virtual void FVirt()    // Инициарование новой цепочки виртуальных методов !!!
        public override void FVirt()
        {
            Console.WriteLine("B.FVirt(): _val = {0}", _val);
        }
    }
}
