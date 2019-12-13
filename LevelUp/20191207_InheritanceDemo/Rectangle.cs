using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _20191130_ClassesDemo;

namespace _20191207_InheritanceDemo
{
    class Rectangle : Point
    {
        private int _width;
        private int _height;

        public Rectangle(int x, int y, int width, int height)
            : base(x, y)
        {
            _width = width;
            _height = height;
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

    }
}
