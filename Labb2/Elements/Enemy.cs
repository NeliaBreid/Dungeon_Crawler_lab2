
using System.Reflection.Metadata;

abstract class Enemy: LevelElement 
{
    protected Enemy (StructPosition Position) : base(Position)
    {
    }

    public string Name { get; set; } 
    public int Health { get; set; }
    public Dice AttackDice { get; set; }
    public Dice DefenceDice { get; set; }


    public abstract void Update(StructPosition position, LevelData levelData);

   

}

