using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message(9,13,18);
            do
            {
                Console.WriteLine(message.MyProperty);
            } while (Console.ReadLine() != "exit");
        }
    }
}
