using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividerLib
{
    class ZerroSecondArgException : Exception
    {
        public DateTime Created { get; private set; }

        public ZerroSecondArgException()
        {
            Created = DateTime.Now;
        }

        public ZerroSecondArgException(string message)
            : base(message)
        {
            Created = DateTime.Now;
        }

        public ZerroSecondArgException(string message, Exception innerException)
            : base(message, innerException)
        {
            Created = DateTime.Now;
        }
    }
}
