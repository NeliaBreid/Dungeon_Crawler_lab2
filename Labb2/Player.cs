
using Labb2;
using System.Drawing;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Player : LevelElement
{
    public string Name { get; set; }
    public int HealthPoints { get; set; }
    public Dice AttackDice { get; set; }
    public Dice DefenceDice { get; set; }

    public Player(StructPosition Position) : base(Position)
    {
        Icon = '@';
        ForegroundColor = ConsoleColor.White;
        Name = "player";
        HealthPoints = 25;
        AttackDice = new Dice(2, 6, 2);
        DefenceDice = new Dice(2, 6, 0);

    }

    public void MovePlayer(LevelData levelData)
    {
        Console.CursorVisible = false;

        ConsoleKey key = Console.ReadKey().Key;

        var positionX = Position.X;
        var positionY = Position.Y;

        switch (key)
        {
            case ConsoleKey.UpArrow:
                positionY -= 1;
                break;
            case ConsoleKey.DownArrow:
                positionY += 1;
                break;
            case ConsoleKey.LeftArrow:
                positionX -= 1;
                break;
            case ConsoleKey.RightArrow:
                positionX += 1;
                break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    return; 
        }

   
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(' ');

          

        var potensiellPosition = new StructPosition(positionX, positionY);

        var element = isElement(potensiellPosition, levelData.Elements);

        if (element != null )
        {
            if(element is Wall )
            {

            }
        }
        else
        {
            Position = new StructPosition(positionX, positionY); //sätter till en ny position
        }

        Draw();
        
    }
    public LevelElement? isElement(StructPosition position, List<LevelElement> levelElements)//StructPosition position) // Om det är en typ så blir det sant
    {

        foreach (LevelElement element in levelElements)
        {

            if (element.Position.Equals(position))
            {

                return element;

            }
        }
        return null;
    }

}
