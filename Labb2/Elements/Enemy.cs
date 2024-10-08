
using Labb2;
using System.Reflection.Metadata;

abstract class Enemy: LevelElement //ärver av basklassen och är abstract, både för orm och råtta
{
    protected Enemy (StructPosition Position) : base(Position)
    {
    }

    public string Name { get; set; } 
    public int Health { get; set; }
    public Dice AttackDice { get; set; }
    public Dice DefenceDice { get; set; }


    public abstract void Update(StructPosition position, LevelData levelData);

    //kunna ärvas och anropar på alla fiender och sedan sköter de olika subklasserna hur de uppdateras
    // ex. förflyttningsmönster

}

