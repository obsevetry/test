﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models.Figures.ZeroDimensional
{
    class Point : ZeroDimensional
    {
        public override void Show()
        {
            UI.DrawPoint(CenterPosition, this);
        }
    }
}
