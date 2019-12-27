using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models
{
    public class Coordinate
    {
        #region Private fields

        protected int _x = 0;
        protected int _y = 0;

        #endregion

        public Coordinate()
        {
            X = 0;
            Y = 0;
        }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        #region Properies
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _x = value;
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
                if (value < 0)
                {
                    return;
                }

                _y = value; 
            }
        }
        #endregion
    }

}
