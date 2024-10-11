
internal class Snake : Enemy 
{

    public Snake(StructPosition Position) : base(Position)
    {
        Health = 25;
        Name = "Snake";
        Icon = 's';
        IsVisible = true;
        ForegroundColor = ConsoleColor.Green;
        AttackDice = new Dice(3, 4, 2);
        DefenceDice = new Dice(1, 8, 5);
    }
    public override void Update(StructPosition position, LevelData levelData) 
    {
        StructPosition newPosition = new StructPosition(Position.X, Position.Y);


        var snakePos = new StructPosition(this.Position);
        var playerPos = new StructPosition(position);


        snakePos = SnakeMovement(snakePos, playerPos);

        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(' ');

        var element = isElement(snakePos, levelData.Elements);
        if (element == null)
        {
            this.Position = snakePos;
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
    public StructPosition SnakeMovement(StructPosition snake, StructPosition player)
    {
        if (snake.DistanceTo(player) <= 2)
        {
            if (player.X < snake.X)
            {
                snake.X += 1;
            }
            else if (player.X > snake.X)
            {
                snake.X -= 1;
            }

            else if (player.Y < snake.Y)
            {
                snake.Y += 1;
            }
            else if (player.Y > snake.Y)
            {
                snake.Y -= 1;
            }
        }
        return snake;
    }
}

