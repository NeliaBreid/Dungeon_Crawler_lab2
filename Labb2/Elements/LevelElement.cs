abstract class LevelElement //abstrakt basklass
{
    public int X { get; set; } //måste vara public för att kunna nå den utifrån
    public int Y { get; set; }
    protected char Icon { get; set; }

    protected ConsoleColor ForegorundColor { get; set; }

    public LevelElement(int x, int y, char icon, ConsoleColor consoleColor)
    {
        X = x;
        Y = y;
        Icon = icon;
        ForegorundColor = consoleColor;

    }


    public void Draw() //inga parametrar
    {
        Console.SetCursorPosition(X, Y);
        Console.ForegroundColor = ForegorundColor;
        Console.WriteLine(Icon);
        Console.ResetColor();


        //anropas för att skriva ut LevelElement på rätt färg och tecken på rätt plats
    }

    //antingen skapa konstruktor eller overridea char
}

