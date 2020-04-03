using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200124_InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoBoxingUnboxing();

            DemoGenerics();

            Console.ReadKey();
        }

        private static void DemoGenerics()
        {
            Print((IEnumerable)null);

            //Print(new object());

            ContainerGeneric<double> c1 = new ContainerGeneric<double>(2.1, -3.6, 3.0, -7.2);

            // !!! контроль типов данных на этапе сборки !!!
            // long item2 = c1[2];

            Console.WriteLine("c1:");
            Print(c1);

            // !!! контроль типов данных на этапе сборки приложения
            //CotainerGeneric<int> c2 = new ContainerGeneric<int>(12, 5, 7.1);
            ContainerGeneric<int> c2 = new ContainerGeneric<int>(12, 5, 7);

            

            Console.WriteLine("c2:");
            Print(c2);

            ContainerGeneric<Persone> c3 = new ContainerGeneric<Persone>(
                    new Persone() { INN = 1, Name = "Vasya" },
                    new Persone() { INN = 2, Name = "Kolya" },
                    new Persone() { INN = 3, Name = "Petya" }
                );

            // !!! контроль типов данных на этапе сборки !!!
            // long item2 = c3[2];

            Console.WriteLine("c3:");
            Print(c3);

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("c3 (foreach):");
            foreach (Persone item in c3)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("c1 (foreach):");
            // !!! отсутствие контроля типов данных на этапе сборки
            foreach (double item in c1)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.WriteLine("c1 (foreach):");
            foreach (double item in c1)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            #region Моделирование работы foreach через while

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("c1 (while):");

            IEnumerable<double> intRefc1IEnumerable = c1;

            //IEnumerator iterator = c1.GetEnumerator();    // !!! нельзя, т.к. выполнена явная реализация интерфейса
            IEnumerator<double> iterator = intRefc1IEnumerable.GetEnumerator();

            while (iterator.MoveNext())
            {
                Console.Write("{0} ", iterator.Current);
            }
            Console.WriteLine();

            #endregion

            Print((IEnumerable)c1);
        }

        private static void DemoBoxingUnboxing()
        {
            Print((IEnumerable)null);

            //Print(new object());

            Container c1 = new Container(2.1, -3.6, 3.0, -7.2);

            //  !!! отсутствие контроля типов данных на этапе сборки
            // long item2 = (long)c1[2];

            Console.WriteLine("c1:");
            Print(c1);

            Container c2 = new Container(12, 5, 7);

            Console.WriteLine("c2:");
            Print(c2);

            Container c3 = new Container(
                    new Persone() { INN = 1, Name = "Vasya" },
                    new Persone() { INN = 2, Name = "Kolya" },
                    new Persone() { INN = 3, Name = "Petya" }
                );

            Console.WriteLine("c3:");
            Print(c3);

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("c3 (foreach):");
            foreach (Persone item in c3)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("c1 (foreach):");
            // !!! отсутствие контроля типов данных на этапе сборки
            //foreach (long item in c1)
            //{
            //    Console.Write("{0} ", item);
            //}
            foreach (double item in c1)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.WriteLine("c1 (foreach):");
            foreach (double item in c1)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            #region Моделирование работы foreach через while

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("c1 (while):");

            IEnumerable intRefc1IEnumerable = c1;

            //IEnumerator iterator = c1.GetEnumerator();    // !!! нельзя, т.к. выполнена явная реализация интерфейса
            IEnumerator iterator = intRefc1IEnumerable.GetEnumerator();

            while (iterator.MoveNext())
            {
                Console.Write("{0} ", iterator.Current);
            }
            Console.WriteLine();

            #endregion

            Print((IEnumerable)c1);
        }

        public static void Print(IEnumerable container)
        {
            if (container == null)
            {
                return;
            }

            foreach (object item in container)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
