using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drob1
{
    public class Drob
    {
        //Дроби вида 'x / y'
        int x = 1;
        int y = 1;

        public Drob(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return x.ToString() + "/" + y.ToString();
        }

        public static Drob operator +(Drob a, Drob b)
        {
            if (a.y == b.y)
                return new Drob(a.x + b.x, a.y);
            else
            {
                //Общий знаменатель
                int z = 0, newXa = 0, newXb = 0;
                if (b.y % a.y == 0)
                {
                    z = b.y;
                    newXb = b.x;
                    newXa = a.x * (b.y / a.y);
                }
                else if (a.y % b.y == 0)
                {
                    z = a.y;
                    newXb = b.x * (a.y / b.y);
                    newXa = a.x;
                }
                else
                {
                    z = a.y * b.y;
                    newXa = a.x * b.y;
                    newXb = b.x * a.y;
                }
                return new Drob(newXa + newXb, z);
            }
        }

        public static Drob operator ++(Drob a)
        {
            return a + (new Drob(a.y, a.y));
        }

    }
}
