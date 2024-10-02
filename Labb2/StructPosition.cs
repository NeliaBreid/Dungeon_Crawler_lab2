using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    internal struct StructPosition
    {
        public int X;
        public int Y;
        public StructPosition(StructPosition position) : this(position.X, position.Y)
        {
            
        }
        public StructPosition(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
