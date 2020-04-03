using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200221_PublisherSubscriberDemo
{
    class IncapsulateSubscriber
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

        public IncapsulateSubscriber(int number, Publisher p1)
        {
            _number = number;

            p1.Subscribe(NextIterationHandlerA);
            p1.Subscribe(NextIterationHandlerB);
        }

        private void NextIterationHandlerA(int index)
        {
            ++_callCount;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t{0}IncapsulateSubscriber({1}).NextIterationHandlerA({2})", DateTime.Now, _number, index);

#if DEBUG
            // !!! Время выполнения обработчиков оказывает влияние на время выполнения Publisher'a !!!
            //     => выполняется в один поток
            // Console.ReadKey();
#endif

        }

        private void NextIterationHandlerB(int index)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t{0}IncapsulateSubscriber({1}).NextIterationHandlerB({2})", DateTime.Now, _number, index);
        }
    }
}