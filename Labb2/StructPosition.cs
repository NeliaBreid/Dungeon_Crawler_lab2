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
        public StructPosition(StructPosition position) : this(position.X, position.Y) //konstruktor
        {

        }
        public StructPosition(int x, int y) //konstruktor för att initera x och y
        {
            X = x;
            Y = y;
        }

        // Metod för att beräkna avstånd till origo?
        public double DistanceToOrigin(StructPosition position)
        {
  
            return Math.Sqrt(X * X + Y * Y);

        }



        public void MoveTo(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }



        //public bool IsPositionWalkable (int x, int y) //kolla vad gränserna för labyrinten är
        //{
        //{

        //    if (X< 0 || Y < 0 || x >= //antalet kolumner || Y >= antalet rader)
        // return false;

        //}
        //    ReturnTypeEncoder grid[y,x] == " " || Grid[y,x] == "X"; 
        //}


    }
}
