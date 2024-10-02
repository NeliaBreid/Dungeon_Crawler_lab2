
using System;
using System.Drawing;

internal class Rat : Enemy //ärver av enemy
{
    public Rat() : base(1, 0, 'r', ConsoleColor.Red)
    {

    }
    public Rat(int x, int y) : base(x, y, 'r',ConsoleColor.Red)
    {
        Health = 10;
        Name = "Rat";
    }

    public override void Update() //rörelsemönstret/ allt som fienden ska göra för varje drag (här specifikt för råtta)
    {
        throw new NotImplementedException();
    }
}

