using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModelLibrary;

namespace _20200430_MVCDemo
{
    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            Model m = new Model();

            ConsoleController ctrlr = new ConsoleController(m);

            ConsoleView v = new ConsoleView(ctrlr);

            ulong time = 0;

            UserAction currentAction = UserAction.NoAction;

            string[] menuItems = new string[]
            {
                "            Menu",
                "<P> - Print data",
                "<I> - Insert new random data",
                "<ESCAPE> - Exit",
                "Your choice: ? " 
            };

            do
            {
                v.ShowMenu(menuItems);
                currentAction = v.GetUserChoice();

                switch (currentAction)
                {
                    case UserAction.Print:
                        v.Print();    // визуализация
                        break;
                    case UserAction.NewData:
                        ctrlr.Add(rnd.Next(-1000, 1000));
                        break;
                    default:
                        break;
                }
               
                ++time;

                System.Threading.Thread.Sleep(50);
            } while (currentAction != UserAction.Exit);            

            v.Pause();
        }
    }
}
