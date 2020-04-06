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
    class StringSet //: ISet<string>    // !!! HW !!!
    {
        public const int DEFAULT_CAPACITY = 100;

        private string[] _items;

        public StringSet(int capacity = DEFAULT_CAPACITY)
        {
            _items = new string[capacity];
        }

        public void Add(string k)
        { 
            int index = HashFunc(k);    // нахождение позиции по ключу

            //
            while (_items[index] != null)    // нахождение свободной позиции
            {
                ++index;

                if (index >= _items.Length)
                {
                    throw new Exception("!!!");
                }
            }

            _items[index] = k;
        }

        public bool this[string key]
        {
            get
            {
                bool result = false;

                int index = HashFunc(key);

                if (_items[index] != null)
                {
                    while (_items[index] != null)
                    {
                        if (IsEqulString(key, _items[index]))
                        {
                            result = true;
                            break;
                        }                    
                        ++index;
                    }                    
                }

                return result;
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
    }
}
