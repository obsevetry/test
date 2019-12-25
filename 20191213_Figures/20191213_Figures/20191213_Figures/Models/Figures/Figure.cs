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

        protected  PenType _penType = PenType.Point;

        #endregion

        public void Move()
        {
        }

        public void Select()
        {
        }

        public void Rotate()
        {
        }

        public void Display()
        {
        }
    }

}
