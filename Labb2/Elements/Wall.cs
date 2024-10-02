
using Labb2;

internal class Wall: LevelElement 
{
    public Wall(StructPosition Position) : base(Position)
        
    {
        Icon = '#';
        ForegroundColor = ConsoleColor.Gray;
    }
}

