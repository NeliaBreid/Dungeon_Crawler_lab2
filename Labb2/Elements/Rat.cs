
using Labb2;
using System;
using System.Drawing;
using System.Net.Http.Headers;

internal class Rat : Enemy //ärver av enemy
{
    public Rat(StructPosition Position) : base(Position)
    {
        Health = 10;
        Name = "Rat";
        Icon = 'r';
        ForegroundColor = ConsoleColor.Red;
    }

    public override void Update(StructPosition position, LevelData levelData) //rörelsemönstret/ allt som fienden ska göra för varje drag (här specifikt för råtta)
    {
        Random random = new Random();

        int direction = random.Next(4);

        switch(direction)
        {
            case 0:
                position.X -= 1;
                break;
            case 1:
                position.X += 1;
                break;
            case 2:
                position.Y -= 1;
                break;
            case 3:
                position.Y += 1;
                break;

        }

        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(' ');

        var potensiellPositionSnake = new StructPosition(position.X, position.Y);

        var element = isElement(potensiellPositionSnake, levelData.Elements);
        if (element == null)
        {
            Position = new StructPosition(potensiellPositionSnake.X, potensiellPositionSnake.Y);
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

