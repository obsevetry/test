using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191221_PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //PolymorphismDemo();

            //A0 obj0 = new A0();
            A0 obj1 = new D();    // !!! ссылка на базовый абстрактный класс может в себе содержать экземпляр производного класса

            //obj1.FVirt();

            Container c1 = new Container();

            c1.Add(obj1);

            c1.Add(new C());
            c1.Add(new B());
            c1.Add(new C());

            c1.Add(new F());

            c1.FVirt();
            Console.ReadKey();

            for (int i = 0; i < 10; i++)
            {                
                Console.Clear();
                c1.ToNext();
                c1.FVirt();

                System.Threading.Thread.Sleep(500);
            }

            Console.ReadKey();

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                c1.ToPrevious();
                c1.FVirt();

                System.Threading.Thread.Sleep(500);
            }

            Console.ReadKey();
        }

        private static void PolymorphismDemo()
        {
            A objA1 = new A();
            B objB1 = new B();
            C objC1 = new C();
            D objD1 = new D();

            objA1.F();
            objB1.F();
            objC1.F();
            objD1.F();

            // !!! ссылка на базовый класс может содержать объект любого производного класса
            Console.ForegroundColor = ConsoleColor.Green;

            A objA2 = new A();
            A objB2 = new B();
            A objC2 = new C();
            A objD2 = new D();

            objA2.F();
            objB2.F();
            objC2.F();
            objD2.F();

            Console.ForegroundColor = ConsoleColor.Red;
            ((C)objD2).F();
            ((D)objD2).F();

            #region RTTI: IS

            if (objA2 is C)    // RTTI !!!
            {
                ((C)objA2).F();
            }
            else
            {
                Console.WriteLine("reference objA2 isn't object of C class");
            }

            #endregion

            #region RTTI: AS

            C objAC2 = objC2 as C;    // RTTI !!!
            if (objAC2 != null)
            {
                objAC2.F();
            }
            else
            {
                Console.WriteLine("reference objC2 isn't object of C class");
            }

            #endregion

            #region :( :( :( bad double RTTI: IS/AS

            if (objA2 is C)    // RTTI (1) !!!
            {
                (objA2 as C).F();    // RTTI (2) !!!
            }
            else
            {
                Console.WriteLine("reference objA2 isn't object of C class");
            }

            #endregion

            Console.ForegroundColor = ConsoleColor.Magenta;

            // !!! все классы насделуются от System.Object (object in C#)

            object objA0 = new A();
            object objB0 = new B();
            object objC0 = new C();
            object objD0 = new D();

            RunMyFFromObject(objA0);

            Console.WriteLine();

            RunMyFFromObject(objB0);

            Console.WriteLine();

            RunMyFFromObject(objC0);

            Console.WriteLine();

            RunMyFFromObject(objD0);

            Console.WriteLine();

            // ------------

            Console.ForegroundColor = ConsoleColor.Yellow;

            RunMyFFromAReference(objA2);

            Console.WriteLine();

            RunMyFFromAReference(objB2);

            Console.WriteLine();

            RunMyFFromAReference(objC2);

            Console.WriteLine();

            RunMyFFromAReference(objD2);
        }

        public static void RunMyFFromObject(object obj)
        {
            if (obj is D)    // RTTI !!!
            {
                ((D)obj).F();
            }
            else
            {
                if (obj is C)    // RTTI !!!
                {
                    ((C)obj).F();
                }
                else
                {
                    if (obj is B)    // RTTI !!!
                    {
                        ((B)obj).F();
                    }
                    else
                    {
                        if (obj is A)    // RTTI !!!
                        {
                            ((A)obj).F();
                        }
                    }
                }
            }
        }
        public static void RunMyFFromAReference(A obj)
        {
            obj.FVirt();
        }
    }
}
