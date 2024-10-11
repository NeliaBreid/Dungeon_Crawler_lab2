
using System.Security.Principal;

abstract class LevelElement 
{
    public StructPosition Position { get; set; }
    protected char Icon { get; set; }
    public bool IsVisible { get; set; }
    protected ConsoleColor ForegroundColor { get; set; }

    public LevelElement(StructPosition Position)
    {
        this.Position = Position;
    }


    public void Draw() 
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.ForegroundColor = ForegroundColor;
        Console.WriteLine(Icon);
        Console.ResetColor();

    }

}

