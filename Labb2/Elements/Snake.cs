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
    public override void Update() //rörelsemönstret/ allt som fienden ska göra för varje drag (här specifikt för orm)
    {
        throw new NotImplementedException();
    }
}

