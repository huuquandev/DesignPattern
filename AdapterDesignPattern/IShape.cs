using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    internal interface IShape
    {
        void Draw(int x1, int y1, int x2, int y2);
    }
}