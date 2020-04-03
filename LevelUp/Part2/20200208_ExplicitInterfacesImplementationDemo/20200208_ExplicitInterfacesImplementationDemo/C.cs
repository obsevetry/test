using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200208_ExplicitInterfacesImplementationDemo
{
    class C : I1, I2
    {
        //public void f()
        //{
        //    Console.WriteLine("C.f()");
        //}

        void I1.f()
        {
            Console.WriteLine("I1.f()");
        }

        void I2.f()
        {
            Console.WriteLine("I2.f()");
        }
    }
}
