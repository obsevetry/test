using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _20191130_ClassesDemo;

namespace _20191207_InheritanceDemo
{
    class Circle : Point
    {
        #region Private data

        private int _r;

        #endregion

        public Circle(int x, int y, int r)
            : base(x, y)
        {
            Console.WriteLine("ctor: Circle({0},{1},{2})", x, y, r);
            // !!! в дочернем классе доступны protected-members родительского класса
            //_x = x;
            //_y = y;

            _r = r;
        }

        ~Circle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("~Circle()");
        }

        //public void Move(int dx, int dy)
        //{
        //    // base.Move(dx, dy);    // запуск метода из базового класса

        //    Console.WriteLine("Circle: Move({0},{1})", dx, dy);
        //    _x += dx;
        //    _y += dy;

        //    // base.Move(dx, dy);    // запуск метода из базового класса
        //}

        public void MovePoint(int dx, int dy)
        {
            base.Move(dx, dy);    // запуск метода из базового класса
        }

        public int R
        {
            get
            {
                return _r;
            }
            set
            {
                _r = value;
            }
        }
    }
}
