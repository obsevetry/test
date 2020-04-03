using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200221_PublisherSubscriberDemo
{
    class Publisher
    {
        public Publisher()
        {

        }

        public event NextIteration NextIter
        {
            add
            {
                _nextIter += value;
            }
            remove
            {
                _nextIter -= value;
            }
        }

        //public void Subscribe(NextIteration ni)
        //{
        //    _nextIter += ni;
        //}

        //public void Unsubscribe(NextIteration ni)
        //{
        //    _nextIter -= ni;
        //}

        public void Run(int iterationCount)
        {
            for (int i = 0; i < iterationCount; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Publisher.Run(), i = {0}", i);

                if (_nextIter != null)    // ! есть подписчики?
                {
                    _nextIter(i);
                }
            }
        }

        private NextIteration _nextIter;    // null
    }
}
