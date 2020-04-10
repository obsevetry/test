using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200403_HashTablesDemo
{
    // Множество строк
    // каждый элемент либо присутствует либо отсутсвует
    //  TKey     -->  TValue
    // string          bool
    class StringSet //: ISet<String>    // !!! HW !!!
    {
        public const int DEFAULT_CAPACITY = 100;

        private List<String>[] _items;

        private string _name;

        public StringSet(string name = "", int capacity = DEFAULT_CAPACITY)
        {
            _name = name;
            _items = new List<String>[capacity];
        }

        public IEnumerator GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        #region Реализация ISet

        //
        // Сводка:
        //     Добавляет элемент в текущий набор и возвращает значение, указывающее, что элемент
        //     был добавлен успешно.
        //
        // Параметры:
        //   item:
        //     Элемент, добавляемый в набор.
        //
        // Возврат:
        //     Значение true, если элемент добавлен в набор; значение false, если элемент уже
        //     был в наборе.
        public bool Add(String item)
        {
            bool result = false;

            int index = HashFunc(item); // нахождение позиции по ключу

            if (_items[index] == null) // Нашли пустой индекс
            {
                _items[index] = new List<String>();
                _items[index].Add(item);

                result = true;
            }
            else if (!this[item]) // Добавляем новое значение в список
            {
                _items[index].Add(item);

                result = true;
            }

            return result;
        }

        //
        // Сводка:
        //     Удаляет все элементы указанной коллекции из текущего набора.
        //
        // Параметры:
        //   other:
        //     Коллекция элементов, которые нужно удалить из набора.
        //
        // Исключения:
        //   T:System.ArgumentNullException:
        //     Свойство other имеет значение null.
        public void ExceptWith(StringSet other) //
        {
            for (int i = 0; i < _items.Count(); i++)
            {
                if (_items[i] == null)
                {
                    continue;
                }

                if (other._items[i] == null)
                {
                    continue;
                }

                foreach (string item in other._items[i])
                {
                    if (_items[i].Contains(item))
                    {
                        _items[i].Remove(item);
                    }
                }
            }
        }

        //
        // Сводка:
        //     Изменяет текущий набор, чтобы он содержал только элементы, которые также имеются
        //     в заданной коллекции.
        //
        // Параметры:
        //   other:
        //     Коллекция для сравнения с текущим набором.
        //
        // Исключения:
        //   T:System.ArgumentNullException:
        //     Свойство other имеет значение null.
        public void IntersectWith(StringSet other)
        {
            for (int i = 0; i < _items.Count(); i++)
            {
                if (_items[i] == null)
                {
                    continue;
                }

                if (other._items[i] == null)
                {
                    _items[i] = null;
                    continue;
                }

                foreach (string item in other._items[i])
                {
                    if (!_items[i].Contains(item))
                    {
                        _items[i].Remove(item);
                    }
                }

                for (int j = 0; j < _items[i].Count(); j++)
                {
                    if (!other._items[i].Contains(_items[i][j]))
                    {
                        _items[i].Remove(_items[i][j]);
                    }
                }
            }
        }

        //
        // Сводка:
        //     Определяет, является ли текущий набор должным (строгим) подмножеством заданной
        //     коллекции.
        //
        // Параметры:
        //   other:
        //     Коллекция для сравнения с текущим набором.
        //
        // Возврат:
        //     Значение true, если текущий набор является строгим подмножеством объекта other;
        //     в противном случае — значение false.
        //
        // Исключения:
        //   T:System.ArgumentNullException:
        //     Свойство other имеет значение null.
        public bool IsProperSubsetOf(StringSet other)
        {
            if (this.Equals(other))
            {
                return false;
            }
            
            bool result = true;

            for (int i = 0; i < _items.Count(); i++)
            {
                if (_items[i] == null)
                {
                    continue;
                }

                if (other._items[i] == null)
                {
                    result = false;
                    break;
                }

                foreach (string item in _items[i])
                {
                    if (!other._items[i].Contains(item))
                    {
                        result = false;
                        break;
                    }
                }

                if (!result)
                {
                    break;
                }

            }

            return result;
        }

        //
        // Сводка:
        //     Определяет, является ли текущий набор должным (строгим) подмножеством заданной
        //     коллекции.
        //
        // Параметры:
        //   other:
        //     Коллекция для сравнения с текущим набором.
        //
        // Возврат:
        //     Значение true, если текущий набор является строгим надмножеством объекта other;
        //     в противном случае — значение false.
        //
        // Исключения:
        //   T:System.ArgumentNullException:
        //     Свойство other имеет значение null.
        public bool IsProperSupersetOf(StringSet other)
        {
            return other.IsProperSubsetOf(this);
        }

        //
        // Сводка:
        //     Определяет, содержат ли текущий набор и указанная коллекция одни и те же элементы.
        //
        // Параметры:
        //   other:
        //     Коллекция для сравнения с текущим набором.
        //
        // Возврат:
        //     Значение true, если текущий набор равен объекту other; в противном случае — значение
        //     false.
        //
        // Исключения:
        //   T:System.ArgumentNullException:
        //     Свойство other имеет значение null.
        public bool SetEquals(StringSet other)
        {
            bool result = true;

            for (int i = 0; i < _items.Count(); i++)
            {
                if (_items[i] == null && other._items[i] == null)
                {
                    continue;
                }

                if (_items[i] != null && other._items[i] != null)
                {
                    if (!_items[i].Equals(other._items[i]))
                    {
                        result = false;
                        break;
                    }
                }
                else
                {
                    result = false;
                    break;
                }           
            }

            return result;
        }

        //
        // Сводка:
        //     Определяет, является ли набор подмножеством заданной коллекции.
        //
        // Параметры:
        //   other:
        //     Коллекция для сравнения с текущим набором.
        //
        // Возврат:
        //     Значение true, если текущий набор является подмножеством объекта other; в противном
        //     случае — значение false.
        //
        // Исключения:
        //   T:System.ArgumentNullException:
        //     Свойство other имеет значение null.
        public bool IsSubsetOf(StringSet other)
        {
            bool result = true;

            for (int i = 0; i < _items.Count(); i++)
            {
                if (_items[i] == null)
                {
                    continue;
                }

                if (other._items[i] == null)
                {
                    result = false;
                    break;
                }

                foreach (string item in _items[i])
                {
                    if (!other._items[i].Contains(item))
                    {
                        result = false;
                        break;
                    }
                }

                if (!result)
                {
                    break;
                }

            }

            return result;
        }

        //
        // Сводка:
        //     Определяет, является ли текущий набор надмножеством заданной коллекции.
        //
        // Параметры:
        //   other:
        //     Коллекция для сравнения с текущим набором.
        //
        // Возврат:
        //     Значение true, если текущий набор является надмножеством объекта other; в противном
        //     случае — значение false.
        //
        // Исключения:
        //   T:System.ArgumentNullException:
        //     Свойство other имеет значение null.
        public bool IsSupersetOf(StringSet other)
        {
            return other.IsSubsetOf(this);
        }

        //
        // Сводка:
        //     Определяет, пересекаются ли текущий набор и указанная коллекция.
        //
        // Параметры:
        //   other:
        //     Коллекция для сравнения с текущим набором.
        //
        // Возврат:
        //     Значение true, если в текущем наборе и объекте other есть хотя бы один общий
        //     элемент; в противном случае — значение false.
        //
        // Исключения:
        //   T:System.ArgumentNullException:
        //     Свойство other имеет значение null.
        public bool Overlaps(StringSet other)
        {
            bool result = false;

            for (int i = 0; i < _items.Count(); i++)
            {
                if (_items[i] == null && other._items[i] == null)
                {
                    continue;
                }

                if (_items[i] != null && other._items[i] != null)
                {
                    foreach (string item in _items[i])
                    {
                        if (other._items[i].Contains(item))
                        {
                            result = true;
                            break;
                        }
                    }
                    if (result)
                    {
                        break;
                    }
                }
            }

            return result;
        }

        //
        // Сводка:
        //     Изменяет текущий набор таким образом, чтобы он содержал только элементы, которые
        //     есть либо в нем, либо в указанной коллекции, но не одновременно там и там.
        //
        // Параметры:
        //   other:
        //     Коллекция для сравнения с текущим набором.
        //
        // Исключения:
        //   T:System.ArgumentNullException:
        //     Свойство other имеет значение null.
        public void SymmetricExceptWith(StringSet other)
        {
            for (int i = 0; i < _items.Count(); i++)
            {
                if (other._items[i] == null)
                {
                    continue;
                }
                foreach (string item in other._items[i])
                {
                    if (_items[i] == null)
                    {
                        Add(item);
                        continue;
                    }

                    if (_items[i].Contains(item))
                    {
                        _items[i].Remove(item);
                    }
                    else
                    {
                        _items[i].Add(item);
                    }
                }
            }
        }

        //
        // Сводка:
        //     Изменяет текущий набор так, чтобы он содержал все элементы, которые имеются в
        //     текущем наборе, в указанной коллекции либо в них обоих.
        //
        // Параметры:
        //   other:
        //     Коллекция для сравнения с текущим набором.
        //
        // Исключения:
        //   T:System.ArgumentNullException:
        //     Свойство other имеет значение null.
        public void UnionWith(StringSet other)
        {
            for (int i = 0; i < _items.Count(); i++)
            {
                if (other._items[i] == null)
                {
                    continue;
                }
                foreach (string item in other._items[i])
                {
                    if (_items[i] == null)
                    {
                        Add(item);
                        continue;
                    }

                    if (!_items[i].Contains(item))
                    {
                        _items[i].Add(item);
                    }
                }
            }
        }
        #endregion

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
        }

        public void RemoveAll()
        {
            for (int i = 0; i < _items.Count(); i++)
            {
                _items[i] = null;
            }
        }

        public void Print()
        {
            Console.Write(_name + ": ");

            for (int i = 0; i < DEFAULT_CAPACITY; i++)
            {
                if (_items[i] == null)
                {
                    continue;
                }
                foreach (string item in _items[i])
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine();
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
    }
}
