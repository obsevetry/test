using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models.Figures.OneDimensional
{
    class Line : OneDimensional
    {
        protected Coordinate _endPosition = new Coordinate();
        public Coordinate EndPosition
        {
            get
            {
                return _endPosition;
            }
            set
            {
                _endPosition = value;
            }
        }

        public void Show()
        {
            ShowOneTip();
        }
    }
}
