using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200124_InterfacesDemo
{
    class Persone
    {
        public int INN { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("({0} - {1})", INN, Name);
        }
    }
}
