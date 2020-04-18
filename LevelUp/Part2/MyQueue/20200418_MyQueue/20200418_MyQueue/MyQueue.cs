using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200418_MyQueue
{
    public class MyQueue : IEnumerable<string>
    {
        private string [] _array;
        private int _head; // First valid element in the queue
        private int _tail; // Last valid element in the queue
        private int _size;

        private const int _GrowFactor = 2;

        public int Count
        {
            get { return _size; }
        }

        public int Length
        {
            get { return _array.Length; }
        }
        public MyQueue(int capacity)
        {
            if (capacity < 0)
                throw new NotImplementedException();

            _array = new string[capacity];
            _head = 0;
            _tail = 0;
            _size = 0;
        }

        public void Enqueue(string item)
        {
            if (_size == _array.Length)
            {
                int newcapacity = _array.Length * _GrowFactor;
                SetCapacity(newcapacity);
            }

            _array[_tail] = item;
            _tail = (_tail + 1) % _array.Length;
            _size++;
        }

        public string Dequeue()
        {
            if (_size == 0)
                throw new NotImplementedException(); ;

            string removed = _array[_head];
            _array[_head] = default;
            _head = (_head + 1) % _array.Length;
            _size--;
            return removed;
        }

        private void SetCapacity(int capacity)
        {
            string[] newArray = new string[capacity];
            if (_size > 0)
            {
                if (_head < _tail)
                {
                    Array.Copy(_array, _head, newArray, 0, _size);
                }
                else
                {
                    Array.Copy(_array, _head, newArray, 0, _array.Length - _head);
                    Array.Copy(_array, 0, newArray, _array.Length - _head, _tail);
                }
            }

            _array = newArray;
            _head = 0;
            _tail = (_size == capacity) ? 0 : _size;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return ((IEnumerable<string>)_array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<string>)_array).GetEnumerator();
        }
    }
}
