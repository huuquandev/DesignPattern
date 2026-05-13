using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}