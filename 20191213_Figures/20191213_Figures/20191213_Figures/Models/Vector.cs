using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models
{
    public class Vector
    {
        #region Protected fields

        protected int _a;
        protected int _b;

        #endregion

        #region Properies
        public int A
        {
            get
            {
                return _a;
            }
            set
            {
                SetA(value);
            }
        }

        public int B
        {
            get
            {
                return _b;
            }
            set
            {
                SetB(value);
            }
        }
        #endregion

        public void SetA(int a)
        {
            if (a < 0)
            {
                return;
            }

            _a = a;
        }
        public void SetB(int b)
        {
            if (b < 0)
            {
                return;
            }

            _b = b;
        }

    }

}
