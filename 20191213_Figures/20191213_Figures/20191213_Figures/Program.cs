using _20191213_Figures.Models;
using _20191213_Figures.Models.Figures.OneDimensional;
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

            Coordinate NewCoordinate = new Coordinate(10, 20);
            Point.Move(NewCoordinate);

            Console.ReadKey();

            Point.СlearDisplayedFigure();

            #endregion


            #region Работа с прямой

            // Показать прямую
            Line Line = new Line
            {
                CenterPosition = new Coordinate(2, 2),
                EndPosition = new Coordinate(20, 20),
                Color = ConsoleColor.Green,
                PenType = PenType.Star
            };

            Line.CalculateEquationParameters(Line.CenterPosition, Line.EndPosition);

            Line.Show();

            Console.ReadKey();

            // Передвинуть прямую
            Line.CenterPosition = new Coordinate(5, 5);

            Line.CalculateEquationParameters(Line.CenterPosition, Line.EndPosition);

            Line.Move(NewCoordinate);

            Console.ReadKey();

            #endregion

        }
    }
}
