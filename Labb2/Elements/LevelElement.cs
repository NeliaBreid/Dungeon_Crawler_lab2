using Labb2;
using System.Security.Principal;

abstract class LevelElement //abstrakt basklass
{
    public StructPosition Position { get; set; }
    protected char Icon { get; set; }

    protected ConsoleColor ForegroundColor { get; set; }

    public LevelElement(StructPosition Position)
    {
        this.Position = Position;
    }


    public void Draw() //inga parametrar
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.ForegroundColor = ForegroundColor;
        Console.WriteLine(Icon);
        Console.ResetColor();


        //anropas för att skriva ut LevelElement på rätt färg och tecken på rätt plats
    }

    //antingen skapa konstruktor eller overridea char
}

