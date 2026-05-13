using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class TurnOnCommand : ICommand
    {
        private readonly Fan fan;

        public TurnOnCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.TurnOn();
        }

        public void Undo()
        {
            fan.TurnOff();
        }
    }
}