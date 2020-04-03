using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190327_TreeDemo
{
    class Program
    {
        static void FillTree(Tree<int, string> t1)
        {
            for (int j = 1; j <= 2; j++)
            {
                for (int i = 3; i < 15; i++)
                {
                    int sign = (i % 2 == 0 ? 1 : -1);
                    int sign1 = (j % 2 == 0 ? 1 : -1);
                    t1.Add(sign*sign1 * i * j, (i*j * 111).ToString());
                }
            }
            
        }
        
        static void Main(string[] args)
        {
            Tree<int, string> t1 = new Tree<int, string>();
            
            // Заполнить дерево
            FillTree(t1);

            Console.WriteLine("t1: ");
            Console.WriteLine(t1);

            Console.WriteLine("");

            // Найти значение по ключу
            int key = 7;
            string result = t1.GetValueByKey(key);
            Console.WriteLine("По ключу {0} найдено значение {1}", key, result);

            // Проапдейтить значение по ключу
            bool isSet = t1.TrySetValueByKey(key, "1954984894");
            
            if (isSet)
            {
                Console.WriteLine("По ключу {0} изменено значение", key);
            }
            else
            {
                Console.WriteLine("Ключ {0} не найден!", key);
            }

            result = t1.GetValueByKey(key);

            Console.WriteLine("По ключу {0} найдено значение {1}", key, result);

            Console.ReadKey();
        }
    }
}
