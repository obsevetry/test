using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191221_PolymorphismDemo
{
    class Container
    {
        #region Data

        private A0[] _items;
        private int _itemsCount;
        private int _currentItemIndex;

        #endregion

        public Container()
        {
            _items = new A0[100];
            _itemsCount = 0;
            _currentItemIndex = 0;
        }

        public void Add(A0 item)
        {
            _items[_itemsCount] = item;
            ++_itemsCount;
        }

        public void FVirt()
        {
            for (int i = 0; i < _itemsCount; i++)
            {
                if (i == _currentItemIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                _items[i].FVirt();
            }
        }

        public void ToNext()
        {
            ++_currentItemIndex;

            if (_currentItemIndex >= _itemsCount)
            {
                _currentItemIndex = 0;
            }
        }

        public void ToPrevious()
        {
            --_currentItemIndex;

            if (_currentItemIndex < 0)
            {
                _currentItemIndex = _itemsCount - 1;
            }
        }
    }
}
