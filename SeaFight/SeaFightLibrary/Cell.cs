using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaFightLibrary
{
    public class Cell
    {
        private Coordinate _coordinate;
        private CellState _state;

        public Coordinate Coordinate { get => _coordinate; }
        public CellState State { get => _state; }

        public Cell(Coordinate Coord)
        {
            _coordinate = Coord;
            _state = CellState.Opened;
        }
    }
}
