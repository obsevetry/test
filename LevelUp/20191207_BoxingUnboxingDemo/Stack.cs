using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191207_BoxingUnboxingDemo
{
    public class Stack
    {
        Entry top;

        public void Push(object data)
        {
            top = new Entry(top, data);
        }

        public object Pop()
        {
            if (top == null)
            { 
                return null;
            }

            object result = top.data;
            top = top.next;
            return result;
        }

        public bool IsEmpty()
        {
            return (top == null);
        }

        class Entry
        {
            public Entry next;
            public object data;
            public Entry(Entry next, object data)
            {
                this.next = next;
                this.data = data;
            }
        }
    }

}
