using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        public int DistanceTo(StructPosition position) // Det här är en beräkning som räknar ut avståndet 
        {
            int dx = position.X - X;
            int dy = position.Y - Y;

            return (int)Math.Sqrt(dx * dx + dy * dy); //pytagoras sats
        }

    }
}
