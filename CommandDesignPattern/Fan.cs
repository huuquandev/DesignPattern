using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class Fan
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turn off");
        }
    }
}