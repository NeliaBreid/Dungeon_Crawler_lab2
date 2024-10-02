internal class Snake: Enemy //ärver av enemy
    {
    public Snake() : base(6, 2, 's', ConsoleColor.Green)
    {
        
    }
    public Snake(int x, int y) : base(x, y, 's',ConsoleColor.Green)
    {
        Health = 25;
        Name = "Snake";
    }
    public override void Update() //rörelsemönstret/ allt som fienden ska göra för varje drag (här specifikt för orm)
    {
        throw new NotImplementedException();
    }
}

