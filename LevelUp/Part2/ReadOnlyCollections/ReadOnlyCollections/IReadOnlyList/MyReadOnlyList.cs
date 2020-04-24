using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IReadOnlyList
{
    public class MyReadOnlyList : IReadOnlyList<string>
    {
        private List<string> _items;

        public string this[int index] => ((IReadOnlyList<string>)_items)[index];

        public int Count => ((IReadOnlyList<string>)_items).Count;

        public MyReadOnlyList(List<string> items)
        {
            _items = items;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return ((IReadOnlyList<string>)_items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IReadOnlyList<string>)_items).GetEnumerator();
        }
    }
}
