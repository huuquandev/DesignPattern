using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    internal class LegacyRectangle
    {
        internal void Draw(int x, int y, int w, int h)
        {
            Console.WriteLine($"Drawing rectangle {x} {y} {w} {h}");
        }
    }
}