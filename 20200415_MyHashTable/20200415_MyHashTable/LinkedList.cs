using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_MyHashTable
{
    public class LinkedList<T> : IEnumerable<T>  // односвязный список
    {
        private Node<T> _head; // первый элемент
        private Node<T> _tail; // последний элемент
        private int count;

        public LinkedList(T data)
        {
            Node<T> node = new Node<T>(data);
            
            _head = node;
            _tail = node;

            count++;
        }

        // добавление элемента
        public bool Add(T data)
        {
            if (Contains(data))
            {
                return false;
            }

            Node<T> node = new Node<T>(data);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;
            }

            _tail = node;

            count++;

            return true;
        }
        // удаление элемента
        public bool Remove(T data)
        {
            bool result = false;

            Node<T> current = _head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        _head = _head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }
                    count--;
                    result = true;
                    break;
                }

                previous = current;
                current = current.Next;
            }

            return result;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        // очистка списка
        public void Clear()
        {
            _head = null;
            _tail = null;
            count = 0;
        }
        // содержит ли список элемент
        public bool Contains(T data)
        {
            bool result = false;

            Node<T> current = _head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    result = true;
                    break;
                }

                current = current.Next;
            }
            return result;
        }
        // добвление в начало
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = _head;
            _head = node;
            if (count == 0)
            {
                _tail = _head;
            }

            count++;
        }
        // реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
