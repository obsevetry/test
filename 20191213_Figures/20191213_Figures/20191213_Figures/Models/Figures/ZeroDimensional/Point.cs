using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models.Figures.ZeroDimensional
{
    class Point : ZeroDimensional
    {
        public void Show()
        {
            ShowOneTip();
        }

        public void Move(Coordinate NewCenterPosition)
        {

            СlearDisplayedFigure();

            CenterPosition = NewCenterPosition;

            ShowOneTip();
        }

        //public static void Rotate()
        //{
        //}

    }
}
