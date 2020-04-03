using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _20191130_ClassesDemo;

namespace _20191207_InheritanceDemo
{
    class UI
    {
        public static void Show(int x, int y, ConsoleColor c = ConsoleColor.White)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = c;
            Console.Write('*');
        }

        public static void Show(Point p, ConsoleColor c = ConsoleColor.White)
        {
            if (p == null)
            {
                return;
            }

            Show(p.X, p.Y, c);
        }

        public static void Show(Circle c, ConsoleColor clr = ConsoleColor.White)
        {
            if (c == null)
            {
                return;
            }

            Show(c.X, c.Y, clr);
            Show(c.X - c.R, c.Y, clr);
            Show(c.X + c.R, c.Y, clr);
            Show(c.X, c.Y - c.R, clr);
            Show(c.X, c.Y + c.R, clr);
        }

        public static void Show(Rectangle r, ConsoleColor clr = ConsoleColor.White)
        {
            if (r == null)
            {
                return;
            }

            for (int j = r.X; j <= r.X + r.Width; j++)
            {
                for (int i = r.Y; i <= r.Y + r.Height; i++)
                {
                    Show(j, i, clr);
                }
            }
        }

        //public static void ShowPoints(int[] xCoords, int[] yCoords, ConsoleColor[] colors)
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        UI.ShowPoint(xCoords[i], yCoords[i], colors[i]);
        //    }
        //}

        //public static void Show(Point[] points)
        //{
        //    for (int i = 0; i < points.Length; i++)
        //    {
        //        UI.Show(points[i]);
        //    }
        //}

        //public static void Show(PolyLine pl)
        //{
        //    for (int i = 0; i < pl.PointsCount; i++)
        //    {
        //        Show(pl[i]);
        //    }
        //}        
    }

}
