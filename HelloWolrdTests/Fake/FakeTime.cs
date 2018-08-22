using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWolrdTests.Fake
{
    class FakeTime : ITime
    {
        public DateTime date { get; }

        public FakeTime(DateTime Pdate)
        {
           date = Pdate;
        }

    }
}
