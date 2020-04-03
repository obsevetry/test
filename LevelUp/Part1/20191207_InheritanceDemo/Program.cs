using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _20191130_ClassesDemo;

namespace _20191207_InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(31, 15, 7);

            c1.Move(2, 3);

            c1.MovePoint(3, 2);

            Point p2 = new Point(5, 7);

            p2.Move(2, 3);

            Rectangle r3 = new Rectangle(5, 3, 10, 7);
            
            UI.Show(c1, ConsoleColor.Green);
            UI.Show(r3, ConsoleColor.Cyan);
            UI.Show(p2, ConsoleColor.Red);

            Console.ReadKey();
        }
    }
}
