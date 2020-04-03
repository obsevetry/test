using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200124_InterfacesDemo
{
    class Container : IContainer, IEnumerable
    {
        private object[] _items;

        public Container(params object[] items)
        {
            _items = (object[])items.Clone();
        }

        public object this[int index]
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ContainerEnumerator(this);
        }

        private struct ContainerEnumerator : IEnumerator
        {
            private readonly Container _c;
            private int _position;

            public ContainerEnumerator(Container c)
            {
                _position = -1;
                _c = c;
            }

            public object Current
            {
                get
                {
                    return _c[_position];
                }
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
