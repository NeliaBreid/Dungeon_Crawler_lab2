
using Labb2;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

internal class LevelData
{
    private List<LevelElement> _elements = new List<LevelElement>();

    public List<LevelElement> Elements
    {
        get { return _elements; }
    }

    //Metod som läser in filen
    public Player Load(string fileName) 
    {
        Player player = null;

        using (StreamReader fileReader = new StreamReader(fileName))
        {

            int y = 0;

            string line;

            while ((line = fileReader.ReadLine()) != null)
            {

                for (int x = 0; x < line.Length; x++) 
                {


                    foreach (char c in line) 
                    {
                        if (c == 'r')
                        {
                            _elements.Add(new Rat(new StructPosition(x, y)));
                        }

                        else if (c == '#')
                        {
                            _elements.Add(new Wall(new StructPosition(x, y)));
                        }

                        else if (c == 's')
                        {
                            _elements.Add(new Snake(new StructPosition(x, y)));
                        }
                        else if (c == '@')
                        {
                            player = new Player(new StructPosition(x, y));
                           
                            _elements.Add(player);
                        }
                        x++;

                    }
                    y++;

                }


            }

        }
        Print();
        return player;
    }
    public void Print()
    {
        Console.Clear();
        foreach (LevelElement element in Elements)
        {
            element.Draw();
        }
    }
    public bool isElement(StructPosition position) // hämta postitionen på fienden och väggarna
    {

        foreach (LevelElement element in Elements)
        {
            if (element.Position.Equals(position))
            {

                return true;

            }
        }
        return false;
    }

}


//Att göra lista: Hämta positionen på fienden och väggar


