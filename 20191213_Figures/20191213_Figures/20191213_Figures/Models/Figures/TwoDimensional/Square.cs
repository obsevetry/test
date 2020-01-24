using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models.Figures.TwoDimensional
{
    class Square : Polygon
    {
        public int D { get; set; } = 0;

        public override void Show()
        {
            int xi = CenterPosition.X;
            int yi = CenterPosition.Y;

            for (int x = xi - D + 1; x < xi + D; x++)
            {
                for (int y = yi - D + 1; y < yi + D; y++)
                {
                    if (Math.Abs((x - xi)) + Math.Abs((y - yi)) <= D / 2)
                    {
                        Coordinate NewCoordinate = new Coordinate
                        {
                            X = x,
                            Y = y
                        };

                        //System.Threading.Thread.Sleep(500);

                        UI.DrawPoint(NewCoordinate, this);
                    }
                }
            }
        }
    }
}
