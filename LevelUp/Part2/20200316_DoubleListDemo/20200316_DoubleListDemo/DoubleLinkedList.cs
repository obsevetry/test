using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200313_ListDemo
{
    class DoubleLinkedList<T> : ILinkedList<T>
    {
        private Node _first = null;
        private Node _last = null;

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
            Node newNode = new Node(item);

            // (2)
            newNode.Next = _first;

            if (IsEmpty())
            {
                // добавление первого элемента в список
                _last = newNode;
            }
            else
            {
                // интеграция нового элемента с существующими элементами
                // (3)
                _first.Prev = newNode;
            }

            // (4)
            _first = newNode;
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Node current = _first;

            while (current != null)
            {
                Console.Write("{0}\t", current.Info);

                current = current.Next;
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            current = _last;

            while (current != null)
            {
                Console.Write("{0}\t", current.Info);

                current = current.Prev;
            }
            Console.WriteLine();
        }

        // Элемент списка
        private class Node
        {
            public Node(T info)
            {
                Info = info;
            }

            public Node Prev { get; set; } = null;    // Ссылка на предыдующий элемент списка

            public T Info { get; set; }    // Информационная часть

            public Node Next { get; set; } = null;    // Ссылка на следующий элемент списка
        }
    }
}
