using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191221_PolymorphismDemo
{
    class F : B
    {
        public override void FVirt()
        {
            //base.FVirt();
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!");
        }
    }
}
