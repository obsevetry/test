using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200124_InterfacesDemo
{
    // 1. объявление контракта
    interface IContainer
    {
        int Count { get; }
        //double this[int index] { get; set; }
        object this[int index] { get; set; }
    }
}
