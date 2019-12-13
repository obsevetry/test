using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191130_ClassesDemo
{
    public class Point
    {
        #region Protected fields

        protected int _x;
        protected int _y;

        #endregion

        // !!! Деструктор
        ~Point()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~Point()");
        }

        // !!! в классах допускаются конструкторы по-умолчанию (в отличии от структур)
        //public Point()
        //    : this(0, 0)
        //{
        //    Console.WriteLine("Point() - default");
        //}

        public Point(int val)
            : this(val, val)
        {
            Console.WriteLine("Point({0})", val);
        }

        public Point(int x, int y)
        {
            Console.WriteLine("Point({0},{1})", x, y);
            _x = x;
            _y = y;
        }

        // конструктор копирования
        public Point(Point source)
            : this(source.X, source.Y)
        {
            Console.WriteLine("copy Point({0},{1})", source.X, source.Y);
            //X = source.X;
            //Y = source.Y;
        }

        //public Point GetCopy()
        //{
        //    Point destination = new Point(X, Y);    // вызов конструктора с 2-мя параметрами

        //    return destination;
        //}

        //public Point GetCopy()
        //{
        //    Point destination = new Point(this);    // вызов конструктора копирования

        //    return destination;
        //}

        public Point GetCopy()
        {
            Point destination = (Point)MemberwiseClone();    // создание поверхностной копии текущего экземпляра

            return destination;
        }


        public static bool IsEqual(Point p1, Point p2)
        {
            return (p1._x == p2._x) && (p1._y == p2._y);
        }

        public void Move(int dx, int dy)
        {
            Console.WriteLine("Point: Move({0},{1})", dx, dy);
            _x += dx;
            _y += dy;
        }

        #region Getters/Setters (методы доступа к данным)

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }

        public void SetX(int x)
        {
            if (x < 0)
            {
                //_error = ErrorType.NegativeXCoordinate;
                return;
            }

            _x = x;
            //_error = ErrorType.NoError;
        }

        public void SetY(int y)
        {
            if (y < 0)
            {
                //_error = ErrorType.NegativeYCoordinate;
                return;
            }

            _y = y;
            //_error = ErrorType.NoError;
        }

        //public ErrorType GetError()
        //{
        //    return _error;
        //}
        
        #endregion

        #region --- === ###   Properies   ### === ---

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                SetX(value);
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                SetY(value);
            }
        }

        // readonly
        //public ErrorType Error
        //{
        //    get
        //    {
        //        return _error;
        //    }
        //}

        #endregion        
    }
}
