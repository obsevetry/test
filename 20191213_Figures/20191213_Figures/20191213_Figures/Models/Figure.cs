using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models
{
    public class Figure
    {
        #region Protected fields

        protected Coordinates _centerPosition = new Coordinates();

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

    public class Coordinates
    {
        #region Private fields

        protected int _x = 0;
        protected int _y = 0;

        #endregion

        #region Properies
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                SetX(value);
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                SetY(value);
            }
        }
        #endregion

        public void SetX(int x)
        {
            if (x < 0)
            {
                return;
            }

            _x = x;
        }
        public void SetY(int y)
        {
            if (y < 0)
            {
                return;
            }

            _y = y;
        }

    }

}
