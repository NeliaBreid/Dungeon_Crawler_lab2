
using Labb2;
using System;
using System.Drawing;

internal class Rat : Enemy //ärver av enemy
{
    public Rat(StructPosition Position) : base(Position)
    {
        Health = 10;
        Name = "Rat";
        Icon = 'r';
        ForegroundColor = ConsoleColor.Red;
    }

    public override void Update() //rörelsemönstret/ allt som fienden ska göra för varje drag (här specifikt för råtta)
    {
        throw new NotImplementedException();
    }
}

