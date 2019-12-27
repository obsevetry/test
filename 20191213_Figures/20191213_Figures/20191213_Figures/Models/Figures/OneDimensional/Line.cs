using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models.Figures.OneDimensional
{
    class Line : OneDimensional
    {
        protected Coordinate _endPosition = new Coordinate();

        private double _k = 0.0;
        private double _b = 0.0;
        private Coordinate _StartPositionPrint = new Coordinate();
        private Coordinate _EndPositionPrint = new Coordinate();
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

        public void CalculateEquationParameters(Coordinate startPosition, Coordinate endPosition)
        {
            if (startPosition.X > endPosition.X)
            {
                _StartPositionPrint.X = endPosition.X;
                _StartPositionPrint.Y = endPosition.Y;

                _EndPositionPrint.X = startPosition.X;
                _EndPositionPrint.Y = startPosition.Y;
            }
            else
            {
                _StartPositionPrint.X = startPosition.X;
                _StartPositionPrint.Y = startPosition.Y;

                _EndPositionPrint.X = endPosition.X;
                _EndPositionPrint.Y = endPosition.Y;
            }

            // y  = k*x + b
            // k = (y2 - y1)/(x2 - x1);
            // b = (x2*y1 - x1*y2)/(x2 - x1);
            _k = (Double)(_EndPositionPrint.Y - _StartPositionPrint.Y) / (Double)(_EndPositionPrint.X - _StartPositionPrint.X);
            _b = (Double)(_EndPositionPrint.X * _StartPositionPrint.Y - _StartPositionPrint.X * _EndPositionPrint.Y) / (Double)(_EndPositionPrint.X - _StartPositionPrint.X);
        }

        public void Show()
        {
            for (int i = _StartPositionPrint.X; i <= _EndPositionPrint.X; i++)
			{
                Coordinate NewCoordinate = new Coordinate
                {
                    X = i,
                    Y = (int)(_k * (double)i + _b)
                };
                DrawPoint(NewCoordinate);
			}
        }

        public void Move(Coordinate NewCenterPosition)
        {

            СlearDisplayedFigure();

            Show();
        }
    }
}
