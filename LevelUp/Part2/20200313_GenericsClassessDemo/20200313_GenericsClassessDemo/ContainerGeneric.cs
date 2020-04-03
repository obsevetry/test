using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200124_InterfacesDemo
{
    class ContainerGeneric<T> : IEnumerable<T>
    {
        private T[] _items;

        public ContainerGeneric(params T[] items)
        {
            _items = (T[])items.Clone();
        }

        public T this[int index]
        {
            get
            {
                // !!! index validation
                return _items[index];
            }
            set
            {
                // !!! index validation
                _items[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return _items.Length;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ContainerEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ContainerEnumerator(this);
        }

        private struct ContainerEnumerator : IEnumerator<T>
        {
            private readonly ContainerGeneric<T> _c;
            private int _position;

            public ContainerEnumerator(ContainerGeneric<T> c)
            {
                _position = -1;
                _c = c;
            }

            object IEnumerator.Current
            {
                get
                {
                    return _c[_position];
                }
            }

            public T Current
            {
                get
                {
                    return _c[_position];
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                ++_position;

                return (_position < _c.Count);
            }

            public void Reset()
            {
                _position = -1;
            }
        }
    }
}
