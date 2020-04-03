using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200313_ListDemo
{
    class SingleLinkedList<T> : IEnumerable<T>
    {
        private Node _first = null;

        public bool IsEmpty()
        {
            return (_first == null);
        }

        public void AddToEnd(T item)
        { 

        }

        public void AddToBegin(T item)
        {
            // (1)
            Node newNode = new Node();

            newNode.Info = item;
            // (2)
            newNode.Next = _first;

            // (3)
            _first = newNode;
        }

        public void Print()
        {
            Node current = _first;

            while (current != null)
            {
                Console.Write("{0}\t", current.Info);

                current = current.Next;
            }
            Console.WriteLine();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        // Элемент списка
        private class Node
        { 
            public T Info { get; set; }    // Информационная часть
            public Node Next { get; set; }    // Ссылка на следующий элемент списка
        }
    }
}
