using Labb2;

internal class Snake: Enemy //ärver av enemy
    {

    public Snake(StructPosition Position) : base(Position)
    {
        Health = 25;
        Name = "Snake";
        Icon = 's';
        ForegroundColor = ConsoleColor.Green;
    }
    public override void Update(StructPosition position) //rörelsemönstret/ allt som fienden ska göra för varje drag (här specifikt för orm)
    {
        Random random = new Random();

        int direction = random.Next(4);

        switch (direction)
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

        Position = new StructPosition(position);

        Draw();

    }
}

