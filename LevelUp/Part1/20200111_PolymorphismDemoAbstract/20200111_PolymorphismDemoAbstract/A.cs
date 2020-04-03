using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191221_PolymorphismDemo
{
    class A : A0    // наследуемся от абстрактного класса
    {
        protected int _val = -1;

        public A()
        {
            ++_val;
            Console.WriteLine("<== ctor: A()");
            //FVirt();    // ???  D? C? B?    // не рекомендуется из конструкторов вызывать виртуальные методы !!!
        }

        public void F()
        {
            Console.WriteLine("A.F()");
        }

        public override void FVirt()
        {
            Console.WriteLine("A.FVirt(): _val = {0}", _val);
        }
    }
}
