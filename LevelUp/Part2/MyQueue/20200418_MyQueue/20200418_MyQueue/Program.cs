using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200418_MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue(10);

            // Заполнение стека
            for (int i = 0; i < 10; i++)
            {
                myQueue.Enqueue(i.ToString());
            }

            Print(myQueue);

            Console.WriteLine("Извлекли {0}", myQueue.Dequeue());
            Console.WriteLine("Извлекли {0}", myQueue.Dequeue());
            Console.WriteLine("Извлекли {0}", myQueue.Dequeue());

            Console.WriteLine("Length {0}", myQueue.Length);

            myQueue.Enqueue("a");
            myQueue.Enqueue("b");

            Console.WriteLine("Length {0}", myQueue.Length);

            Console.WriteLine("Извлекли {0}", myQueue.Dequeue());
            Console.WriteLine("Извлекли {0}", myQueue.Dequeue());

            Print(myQueue);

            Console.ReadKey();

        }

        private static void Print(MyQueue myQueue)
        {
            foreach (string item in myQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
