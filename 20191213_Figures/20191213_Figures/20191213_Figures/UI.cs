using _20191213_Figures.Models;
using _20191213_Figures.Models.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures
{
    class UI
    {
        public static void DrawPoint(Coordinate Coordinate, Figure figure)
        {
            Console.SetCursorPosition(Coordinate.X, Coordinate.Y);
            Console.ForegroundColor = figure.Color;
            Console.Write(UI.GetPenPencilValue(figure.PenType));
        }

        public static string GetPenPencilValue(PenType penType)
        {
            switch (penType)
            {
                case PenType.Dash:
                    return "-";
                case PenType.Point:
                    return ".";
                case PenType.Star:
                    return "*";
                default:
                    return "*";
            }
        }
    }
}
