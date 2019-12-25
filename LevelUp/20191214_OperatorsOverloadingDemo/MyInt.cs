using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191214_OperatorsOverloadingDemo
{
    class MyInt
    {
        #region MyRegion

        private int _val;

        #endregion

        public MyInt(int val)
        {
            _val = val;
        }

        public int Val
        {
            get
            {
                return _val;
            }
            set
            {
                _val = value;
            }
        }

        public static MyInt Add(MyInt argFirst, MyInt argSecond)
        {
            MyInt result = new MyInt(argFirst._val + argSecond._val);

            return result;
        }

        #region Арифметические операции

        public static MyInt operator+ (MyInt argFirst, MyInt argSecond)
        {
            MyInt result = new MyInt(argFirst._val + argSecond._val);

            return result;
        }

        public static MyInt operator -(MyInt argFirst, MyInt argSecond)
        {
            return new MyInt(argFirst._val - argSecond._val);
        }

        public static MyInt operator -(MyInt argFirst, int argSecond)
        {
            return new MyInt(argFirst._val - argSecond);
        }

        public static MyInt operator -(int argFirst, MyInt argSecond)
        {
            return new MyInt(argFirst - argSecond._val);
        }


        // MyInt arg - содержит предыдущее состояние экземпляря
        public static MyInt operator ++(MyInt arg)
        {
            MyInt result = new MyInt(arg._val + 1);    // новое состояние

            return result;
        }

        #endregion

        #region операции сравнения

        public static bool operator ==(MyInt argFirst, MyInt argSecond)
        {
            return (argFirst._val == argSecond._val);
        }

        public static bool operator !=(MyInt argFirst, MyInt argSecond)
        {
            //return (argFirst._val != argSecond._val);
            return !(argFirst == argSecond);    // обращение к операции равенства
        }

        public static bool operator >(MyInt argFirst, MyInt argSecond)
        {
            return (argFirst._val > argSecond._val);
        }

        public static bool operator <(MyInt argFirst, MyInt argSecond)
        {
            return (argFirst._val < argSecond._val);
        }

        public static bool operator >=(MyInt argFirst, MyInt argSecond)
        {
            return !(argFirst < argSecond);
        }

        public static bool operator <=(MyInt argFirst, MyInt argSecond)
        {
            return !(argFirst > argSecond);
        }

        //public static MyInt operator -(MyInt argFirst, MyInt argSecond)
        //{
        //    return new MyInt(argFirst._val - argSecond._val);
        //}

        #endregion

        #region Битовые операции

        public static MyInt operator ^(MyInt argFirst, MyInt argSecond)
        {
            return new MyInt(argFirst._val ^ argSecond._val);
        }

        //public static MyInt operator &(MyInt argFirst, MyInt argSecond)
        //{
        //    return new MyInt(argFirst._val & argSecond._val);
        //}

        #endregion
        public static bool operator &(MyInt argFirst, MyInt argSecond)
        {
            return (argFirst._val != 0) & (argSecond._val != 0);
        }

        #region --- ====    Операции преобразования типа    === ---

        //  неявное
        public static implicit operator float(MyInt arg)
        {
            return arg._val;
        }

        //  неявное
        public static implicit operator bool(MyInt arg)
        {
            return (arg._val != 0);
        }

        // явное
        public static explicit operator int(MyInt arg)
        {
            return arg._val;
        }

        // явное
        public static explicit operator double(MyInt arg)
        {
            return arg._val;
        }

        #endregion
    }
}
