using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200221_PublisherSubscriberDemo
{
    class Subscriber
    {
        #region Data

        private readonly int _number;

        private int _callCount = 0;

        #endregion

        public int CallCount
        {
            get 
            {
                return _callCount;
            }
        }

        public Subscriber(int number)
        {
            _number = number;
        }

        public void NextIterationHandlerOne(int index)
        {
            ++_callCount;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t{0}Subscriber({1}).NextIterationHandlerOne({2})", DateTime.Now, _number, index);

#if DEBUG
            // !!! Время выполнения обработчиков оказывает влияние на время выполнения Publisher'a !!!
            //     => выполняется в один поток
            // Console.ReadKey();
#endif

        }

        public void NextIterationHandlerTwo(int index)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t{0}Subscriber({1}).NextIterationHandlerTwo({2})", DateTime.Now, _number, index);
        }
    }
}
