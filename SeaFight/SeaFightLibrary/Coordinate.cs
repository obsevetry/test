using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaFightLibrary
{
    public class Coordinate
    {
        private string _x;
        private string _y;
        private string _cellCoordinate;

        public string X { get => _x; }
        public string Y { get => _y; }
        public string CellCoordinate { get => _cellCoordinate; }

        public Coordinate(string A, string B)
        {
            _x = A;
            _y = B;
            _cellCoordinate = _x + _y;
        }
    }
}
