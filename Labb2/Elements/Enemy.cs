
using Labb2;
using System.Reflection.Metadata;

abstract class Enemy: LevelElement //ärver av basklassen och är abstract
    {
    private string _snakeName;
    private string _ratName;
    private int _health;
    Dice AttackDice;
    Dice DefenceDice;
   
    //lägger till en funktion som är specifik för fienden
    // property för namnet snake
    //property för namnet rat
    // property för hälsa
    // property av AttackDice (av typen Dice)
    // property av DefenceDice (av typen Dice)
    
    abstract void Update()
    {
        //kunna ärvas och anropar på alla fiender och sedan sköter de olika subklasserna hur de uppdateras
        // ex. förflyttningsmönster
    }
    }

