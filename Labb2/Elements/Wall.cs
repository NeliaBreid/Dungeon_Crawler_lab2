
internal class Wall: LevelElement //Färgen på muren ska hårdkodas och tecknet för en vägg (en grå hashtag)
{
    public Wall(int x, int y) : base(x, y, '#', ConsoleColor.Gray)  //konstruktor chaining
    {

    }
}

