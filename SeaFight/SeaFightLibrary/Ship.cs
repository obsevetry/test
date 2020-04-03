using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaFightLibrary
{
    public class Ship
    {
        private int _cellsNumber;
        private ShipState _state;
        private ShipPosition _position;
        private Cell [] _cells;

        public int CellsNumber { get => _cellsNumber; }
        public ShipState State { get => _state; }
        public ShipPosition Position { get => _position; }
        public Cell[] Cells { get => _cells; }

        public Ship()
        {
        
        }
    }
}
