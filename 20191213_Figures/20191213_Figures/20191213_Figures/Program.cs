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
            Figure point = new Point
            {
                CenterPosition = new Coordinate(2, 5),
                Color = ConsoleColor.Red,
                PenType = PenType.Star
            };

            Figure line = new Line
            {
                CenterPosition = new Coordinate(10, 2),
                EndPosition = new Coordinate(20, 20),
                Color = ConsoleColor.Green,
                PenType = PenType.Star
            };

            Figure circle = new Circle
            {
                CenterPosition = new Coordinate(50, 10),
                R = 10,
                Color = ConsoleColor.Blue,
                PenType = PenType.Dash
            };

            Figure square = new Square
            {
                CenterPosition = new Coordinate(10, 10),
                D = 20,
                Color = ConsoleColor.DarkYellow,
                PenType = PenType.Star
            };

            Picture picture = new Picture();

            //picture.AddFigure(point);

            //picture.AddFigure(line);

            //picture.AddFigure(circle);

            picture.AddFigure(square);

            picture.Show();

            Console.ReadKey();

            picture.Move();

            Console.ReadKey();
        }
    }
}
