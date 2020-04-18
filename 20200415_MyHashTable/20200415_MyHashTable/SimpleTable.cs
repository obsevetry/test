using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_MyHashTable
{
    public class SimpleTable : IEnumerable<string>, ISet<string>
    {
        public const int DEFAULT_CAPACITY = 100;

        private string _name;

        private LinkedList<string>[] _items;

        public string Name { get => _name; }

        public int Count => _items.Count();

        public bool IsReadOnly => false;

        public SimpleTable(string name, int capacity = DEFAULT_CAPACITY)
        {
            _name = name;
            _items = new LinkedList<string>[capacity];
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var itemList in _items)
            {
                if (itemList == null)
                {
                    continue;
                }
                foreach (var item in itemList)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var itemList in _items)
            {
                if (itemList == null)
                {
                    continue;
                }
                foreach (var item in itemList)
                {
                    yield return item;
                }
            }
        }

        // Хэш-функция: string ---> int
        // Требования:
        //     1. Скорость ее выполнения
        //     2. Случайность получаемых значений
        private int HashFunc(string s)
        {
            int hash = s[0] + s[1] + s[2];    // строим хеш на основе кодов первых 3-х символов строки

            return hash % _items.Length;    // остаток от деления с учетом размера массива исходных данных
        }

        // Проверка на тождественность
        private bool IsEqulString(string s1, string s2)
        {
            return (s1 == s2);
        }

        public bool this[string key]
        {
            get
            {
                bool result = false;

                int index = HashFunc(key);

                if (_items[index] != null)
                {
                    foreach (string item in _items[index]) // Проверка есть ли уже такое значение в списке
                    {
                        if (IsEqulString(item, key))
                        {
                            result = true;
                            break;
                        }
                    }
                }

                return result;
            }
            //set
            //{
            //    int index = HashFunc(key);

            //    if (_items[index] != null)
            //    {
            //        foreach (string item in _items[index]) // Проверка есть ли уже такое значение в списке
            //        {
            //            if (IsEqulString(item, key))
            //            {
            //                _items[index] = null;
            //                break;
            //            }
            //        }
            //    }
            //    else
            //    {

            //    }
            //}
        }

        public bool Add(string item)
        {
            bool result = false;

            int index = HashFunc(item); // нахождение позиции по ключу

            if (_items[index] == null) // Нашли пустой индекс
            {
                _items[index] = new LinkedList<String>(item);

                result = true;
            }
            else
            {
                result = _items[index].Add(item);
            }

            return result;
        }
        public bool Remove(string item)
        {
            bool result = false;

            int index = HashFunc(item); // нахождение позиции по ключу

            if (_items[index] != null) // Нашли пустой индекс
            {
                result = _items[index].Remove(item);
            }

            return result;
        }

        public void UnionWith(IEnumerable<string> other)
        {
            foreach (var item in other)
            {
                Add(item);
            }
        }

        public void IntersectWith(IEnumerable<string> other)
        {
            foreach (string item in this)
            {
                if (!other.Contains(item))
                {
                    Remove(item);
                }
            }
        }

        public void ExceptWith(IEnumerable<string> other)
        {
            foreach (string item in this)
            {
                if (other.Contains(item))
                {
                    Remove(item);
                }
            }
        }

        public void SymmetricExceptWith(IEnumerable<string> other)
        {
            List<string> deleted = new List<string>();
            
            foreach (string item in this)
            {
                if (other.Contains(item))
                {
                    deleted.Add(item);
                    Remove(item);
                }
            }

            foreach (string item in other)
            {
                if (deleted.Contains(item))
                {
                    continue;
                }

                Add(item);
            }

        }

        public bool IsSubsetOf(IEnumerable<string> other)
        {
            bool result = false;

            foreach (string item in this)
            {
                if (!other.Contains(item))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool IsSupersetOf(IEnumerable<string> other)
        {
            bool result = false;

            foreach (string item in other)
            {
                if (!Contains(item))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool IsProperSupersetOf(IEnumerable<string> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<string> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IEnumerable<string> other)
        {
            throw new NotImplementedException();
        }

        public bool SetEquals(IEnumerable<string> other)
        {
            throw new NotImplementedException();
        }

        void ICollection<string>.Add(string item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            Array.Clear(_items, 0, _items.Count());
        }

        public bool Contains(string searchItem)
        {
            bool result = false;

            foreach (string item in this)
            {
                if (IsEqulString(item, searchItem))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
    }
}
