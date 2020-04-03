using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200208_ExplicitInterfacesImplementationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            C obj = new C();

            //obj.f();

            I1 refI1 = obj;

            refI1.f();

            I2 refI2 = obj;

            refI2.f();

            Console.ReadKey();
        }
    }
}
