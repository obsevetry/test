using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models.Figures.OneDimensional
{
    class Line : OneDimensional
    {
        #region Private fields      
        private double _k = 0.0;
        private double _b = 0.0;
        private Coordinate _endPosition = new Coordinate();
        #endregion

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

        public void CalculateEquationParameters()
        {
            if (_centerPosition == null || _endPosition == null)
            {
                return;
            }
            // y  = k*x + b
            // k = (y2 - y1)/(x2 - x1);
            // b = (x2*y1 - x1*y2)/(x2 - x1);
            _k = (Double)(_endPosition.Y - _centerPosition.Y) / (Double)(_endPosition.X - _centerPosition.X);
            _b = (Double)(_endPosition.X * _centerPosition.Y - _centerPosition.X * _endPosition.Y) / (Double)(_endPosition.X - _centerPosition.X);
        }

        public override void Show()
        {
            CalculateEquationParameters();

            for (int i = _centerPosition.X; i <= _endPosition.X; i++)
			{
                Coordinate NewCoordinate = new Coordinate
                {
                    X = i,
                    Y = (int)(_k * (double)i + _b)
                };

                UI.DrawPoint(NewCoordinate, this);
			}
        }
    }
}
