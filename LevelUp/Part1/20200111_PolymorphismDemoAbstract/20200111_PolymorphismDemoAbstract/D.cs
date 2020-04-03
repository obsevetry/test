using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191221_PolymorphismDemo
{
    sealed class D : C    // sealed - запрещает дальнейшее наследование от класса D
    {
        public D()
        {
            ++_val;
        }

        public void F()
        {
            Console.WriteLine("D.F()");
            //FVirt();
        }

        public override void FVirt()
        {
            Console.WriteLine("D.FVirt(): _val = {0}", _val);
            //            base.FVirt();
            // ((A)(this)).FVirt();    // !!! бесконечная рекурсия т.к. используется переопределенная версия метода
        }
    }
}
