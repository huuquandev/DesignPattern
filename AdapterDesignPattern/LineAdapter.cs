using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    internal class LineAdapter : IShape
    {
        private readonly LegacyLine _legacyLine;

        public LineAdapter(LegacyLine legacyLine)
        {
            _legacyLine = legacyLine;
        }

        public void Draw(int x1, int y1, int x2, int y2)
        {
            _legacyLine.Draw(x1, y1, x2, y2);
        }
    }
}