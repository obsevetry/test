using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models
{
    public class Figure
    {
        #region Protected fields

        Coordinates _centerPosition = new Coordinates();

        #endregion
`

    }

    public class Coordinates
    {
        #region Private fields

        protected int _x;
        protected int _y;

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
