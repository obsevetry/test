using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models.Figures
{
    public class Figure
    {

        #region Protected fields

        protected Coordinate _centerPosition = new Coordinate();

        protected ConsoleColor _color = ConsoleColor.DarkGreen;

        protected PenType _penType = PenType.Point;

        protected List<Coordinate> CoordinatesDisplayedFigure = new List<Coordinate>();

        #endregion

        #region Properties
        public Coordinate CenterPosition
        {
            get
            {
                return _centerPosition;
            }
            set
            {
                _centerPosition = value;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public PenType PenType
        {
            get
            {
                return _penType;
            }
            set
            {
                _penType = value;
            }
        }
        #endregion
        public void DrawPoint(Coordinate Coordinate)
        {
            Console.SetCursorPosition(Coordinate.X, Coordinate.Y);
            Console.ForegroundColor = Color;
            Console.Write(UI.GetPenPencilValue(PenType));

            CoordinatesDisplayedFigure.Add(Coordinate);
        }

        public void СlearDisplayedFigure()
        {
            foreach (var item in CoordinatesDisplayedFigure)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.Write(" ");
            }
        }
    }

}
