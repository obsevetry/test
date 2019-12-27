using _20191213_Figures.Models;
using _20191213_Figures.Models.Figures.ZeroDimensional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Работа с точкой 

            // Показать точку
            Point Point = new Point
            {
                CenterPosition = new Coordinate(2, 5),
                Color = ConsoleColor.Red,
                PenType = PenType.Star
            };

            Point.Show();

            Console.ReadKey();

            // Передвинуть точку
            Point.СlearDisplayedFigure();

            Coordinate NewCoordinate = new Coordinate(5, 5);
            Point.Move(NewCoordinate);

            Console.ReadKey();

            #endregion


        }
    }
}
