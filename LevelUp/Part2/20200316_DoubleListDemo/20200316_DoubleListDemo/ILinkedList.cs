using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200313_ListDemo
{
    interface ILinkedList<T> //: IEnumerable<T>
    {
        bool IsEmpty();
        void AddToBegin(T item);
        void Print();    // ToDo:  ---> : IEnumerable<T> implementation
    }
}
