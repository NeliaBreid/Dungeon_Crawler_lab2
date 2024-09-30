abstract class LevelElement //abstrakt basklass
{
    private int _x {  get; set; }
    private int _y { get; set; }
    private char _char {  get; set; }  // property char


    private ConsoleColor ForegorundColor { get; set; }  // property för console.color



    public Draw () //inga parametrar
    {
        //anropas för att skriva ut LevelElement på rätt färg och tecken på rätt plats
    }
}

