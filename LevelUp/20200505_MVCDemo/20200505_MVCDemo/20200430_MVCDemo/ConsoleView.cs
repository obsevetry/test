using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200430_MVCDemo
{
    // View
    class ConsoleView
    {
        public ConsoleView(ConsoleController ctrl)
        {
            _ctrl = ctrl;
        }

        public void Print()
        {
            //Print(_ctrl.GetPositiveData());
            Print(_ctrl.GetData());
        }

        public void Print(IEnumerable<int> items)
        {
            int oldXPos = Console.CursorLeft;
            int oldYPos = Console.CursorTop;

            Console.SetCursorPosition(0, 10);

            foreach (int item in items)
            {
                Console.Write("{0} ", item);
            }

            Console.SetCursorPosition(oldXPos, oldYPos);
        }

        public void Pause()
        {
            Console.Write("Press any key to continue...");

            Console.ReadKey();
        }

        public void ShowMenu(string[] items)
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public UserAction GetUserChoice()
        {
            UserAction result = UserAction.NoAction;

            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        result = UserAction.Exit;
                        break;
                    case ConsoleKey.P:
                        result = UserAction.Print;
                        break;
                    case ConsoleKey.I:
                        result = UserAction.NewData;
                        break;
                }
            }

            return result;
        }

        private readonly ConsoleController _ctrl;
    }
}
