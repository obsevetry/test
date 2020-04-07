using System;
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
    class StringSet //: //ISet<List<String>>    // !!! HW !!!
    {
        public const int DEFAULT_CAPACITY = 100;

        private List<String>[] _items;

        private string _name;

        public StringSet(string name = "", int capacity = DEFAULT_CAPACITY)
        {
            _name = name;
            _items = new List<String>[capacity];
        }

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
        public void ExceptWith(StringSet other)
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

                if (i >= other._items.Count())
                {
                    return;
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
