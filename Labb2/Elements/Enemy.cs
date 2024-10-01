
using Labb2;
using System.Reflection.Metadata;

abstract class Enemy: LevelElement //ärver av basklassen och är abstract, både för orm och råtta
{
    protected Enemy (int x, int y, char icon, ConsoleColor consoleColor) : base(x, y, icon, consoleColor)
    {
        
    }

    public string Name { get; set; } 
    public int Health { get; set; }
    public Dice AttackDice { get; set; }
    public Dice DefenceDice { get; set; }


    //lägger till en funktion som är specifik för fienden
    // property för namnet snake
    //property för namnet rat
    // property för hälsa
    // property av AttackDice (av typen Dice)
    // property av DefenceDice (av typen Dice)

    public abstract void Update();
    
        //kunna ärvas och anropar på alla fiender och sedan sköter de olika subklasserna hur de uppdateras
        // ex. förflyttningsmönster
    
    }

