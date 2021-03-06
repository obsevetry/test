﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models.Figures.TwoDimensional
{
    class Circle : TwoDimensional
    {
        public int R { get; set; } = 0;

        public override void Show()
        {
            int xi = CenterPosition.X;
            int yi = CenterPosition.Y;
            int radius = R;

            for (int x = xi - radius + 1; x < xi + radius; x++)
                {
                for (int y = yi - radius + 1; y < yi + radius; y++)
                    {
                        if ((x - xi) * (x - xi) + (y - yi) * (y - yi) <= radius * radius)
                        {
                        Coordinate NewCoordinate = new Coordinate
                        {
                            X = x,
                            Y = y
                        };

                        UI.DrawPoint(NewCoordinate, this);
                    }
                }
            }
        }
    }
}
