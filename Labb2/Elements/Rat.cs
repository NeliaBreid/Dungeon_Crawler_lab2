
using System;
using System.Drawing;
using System.Net.Http.Headers;

internal class Rat : Enemy 
{
    public Rat(StructPosition Position) : base(Position)
    {
        Health = 10;
        Name = "Rat";
        Icon = 'r';
        IsVisible = true;
        ForegroundColor = ConsoleColor.Red;
        AttackDice = new Dice(1, 6, 3);
        DefenceDice = new Dice(1, 6, 1);
    }

    public override void Update(StructPosition position, LevelData levelData) 
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

        var newSnakePosition = new StructPosition(position.X, position.Y);

        var element = isElement(newSnakePosition, levelData.Elements);
        if (element == null)
        {
            Position = new StructPosition(newSnakePosition.X, newSnakePosition.Y);
        }

    }

    public LevelElement? isElement(StructPosition position, List<LevelElement> levelElements)
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

