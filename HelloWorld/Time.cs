using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Time : ITime
    {
        public DateTime date
        {
            get { return DateTime.Now; }
                    
        }
    }
}
