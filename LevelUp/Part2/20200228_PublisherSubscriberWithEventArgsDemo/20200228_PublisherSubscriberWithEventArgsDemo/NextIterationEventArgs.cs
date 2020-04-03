using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200221_PublisherSubscriberDemo
{
    class NextIterationEventArgs : EventArgs
    {
        public int Iteration { get; private set; }

        public NextIterationEventArgs(int iterationNumber)
        {
            Iteration = iterationNumber;
        }
    }
}
