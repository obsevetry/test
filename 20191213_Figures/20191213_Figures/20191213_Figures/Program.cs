using _20191213_Figures.Models;
using _20191213_Figures.Models.Figures;
using _20191213_Figures.Models.Figures.OneDimensional;
using _20191213_Figures.Models.Figures.TwoDimensional;
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
            Figure[] Pictures = new Figure [10];

            Pictures[0] = new Point
            {
                CenterPosition = new Coordinate(2, 5),
                Color = ConsoleColor.Red,
                PenType = PenType.Star
            };

            Pictures[1] = new Line
            {
                CenterPosition = new Coordinate(10, 2),
                EndPosition = new Coordinate(20, 20),
                Color = ConsoleColor.Green,
                PenType = PenType.Star
            };

            Pictures[2] = new Circle
            {
                CenterPosition = new Coordinate(50, 10),
                R = 10,
                Color = ConsoleColor.Blue,
                PenType = PenType.Dash
            };

            // Show
            for (int i = 0; i < Pictures.Length; i++)
            {
                if (Pictures[i] == default)
                {
                    continue;
                }

                Pictures[i].Show();
            }

            Console.ReadKey();

            // Move
            for (int i = 0; i < Pictures.Length; i++)
            {
                if (Pictures[i] == default)
                {
                    continue;
                }

                Coordinate NewPosition = new Coordinate(Pictures[i].CenterPosition.X + 25, Pictures[i].CenterPosition.Y + 5);

                Pictures[i].Move(NewPosition);
            }

            Console.ReadKey();

            return;


            #region Работа с точкой 

            // Показать точку
            Point point = new Point
            {
                CenterPosition = new Coordinate(2, 5),
                Color = ConsoleColor.Red,
                PenType = PenType.Star
            };

            point.Show();

            Console.ReadKey();

            // Передвинуть точку
            Coordinate NewPoint = new Coordinate(10, 20);
            point.Move(NewPoint);

            Console.ReadKey();

            point.СlearDisplayedFigure();

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

            Line.Show();

            Console.ReadKey();

            // Передвинуть прямую
            Coordinate NewStartPosition = new Coordinate(50, 10);

            Line.Move(NewStartPosition);

            Console.ReadKey();

            Line.СlearDisplayedFigure();

            #endregion

            #region Работа с окружностью

            // Показать круг
            Circle circle = new Circle
            {
                CenterPosition = new Coordinate(10, 10),
                R = 10,
                Color = ConsoleColor.Blue,
                PenType = PenType.Dash
            };

            circle.Show();

            Console.ReadKey();

            // Передвинуть прямую
            NewStartPosition = new Coordinate(40, 10);

            circle.Move(NewStartPosition);

            Console.ReadKey();

            #endregion


        }
    }
}
