using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200403_HashTablesDemo
{
    //public class StringSetIEnumerator : IEnumerator<List<string>>
    //{
    //    List<string>[] _items;
    //    int position = -1;
    //    public StringSetIEnumerator(List<string>[] _items)
    //    {
    //        this._items = _items;
    //    }

    //    public List<string> Current
    //    {
    //        get
    //        {
    //            if (position == -1 || position >= _items.Length)
    //                throw new InvalidOperationException();
    //            return _items[position];
    //        }
    //    }

    //    object IEnumerator.Current => throw new NotImplementedException();

    //    public bool MoveNext()
    //    {
    //        if (position < _items.Length - 1)
    //        {
    //            position++;
    //            return true;
    //        }
    //        else
    //            return false;
    //    }

    //    public void Reset()
    //    {
    //        position = -1;
    //    }
    //    public void Dispose() { }
    //}

}
