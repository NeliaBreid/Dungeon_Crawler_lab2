
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
    
        return player;
    }
    public void PrintVisibleElements(StructPosition playerPosition, List<LevelElement> elements)

    {
        int visionRange = 5; //sätter avståndet range

        foreach (var element in elements)
        {
            // Calculate the distance between the player and the current element
            double distance = playerPosition.DistanceTo(element.Position);

            if (distance <= visionRange)
            {
                // Draw the element

                if (element is Wall)
                {
                    // If it's a wall that has been seen, keep it drawn
                    element.Draw();
                }

                else if (element is Enemy && element.IsVisible)
                {
                    element.Draw();
                }

            }

        }
    }
    public bool isElement(StructPosition position) 
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


