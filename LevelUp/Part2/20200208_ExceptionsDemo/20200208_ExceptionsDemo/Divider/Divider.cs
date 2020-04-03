using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividerLib
{
    public class Divider
    {
        public static void TestDivByZerro()
        {
            bool ok = true;

            do
            {
                ok = true;

                try
                {
                    int a = 10;

                    Console.Write("b? : ");
                    int b = int.Parse(Console.ReadLine());

                    int result = DoDiv(a, b);
                    Console.WriteLine("{0} / {1} = {2}", a, b, result);
                }
                catch (DivideByZeroException ex)
                {
                    //Console.WriteLine("Делнение на ноль!!!");
                    throw new ZerroSecondArgException("Делнение на ноль!!!", ex);
                    ok = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Введено не число! Повторите ввод!!!");
                    ok = false;
                }
                finally
                {
                    // !!! выполняется независимо от того было исключение или нет !!!
                    // ... закрытие фалов, соединений с БД и т.д.
                    Console.WriteLine("finally block");
                }
            } while (!ok);
        }
        public static int DoDiv(int a, int b)
        {
            return a / b;
        }
    }
}
