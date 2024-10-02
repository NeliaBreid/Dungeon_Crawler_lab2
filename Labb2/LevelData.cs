﻿
internal class LevelData
{
    private List<LevelElement> _elements = new List<LevelElement>();

    public List<LevelElement> Elements
    {
        get { return _elements; }
    }
    public void Load(string fileName) //Metod som ska läsa in filen
    {
        //if (File.Exists(fileName))
        //{
        //    Console.WriteLine("File found");
        //}
        //else
        //{
        //    Console.WriteLine("File not found");

        //}
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
                            _elements.Add(new Rat(x, y));

                        }
                        else if (c == '#')
                        {
                            _elements.Add(new Wall(x, y));
                        }
                        else if (c == 's')
                        {
                            _elements.Add(new Snake(x, y));
                        }
                        x++;
                    }
                    y++;

                }

                //LevelData level = new LevelData();
                //foreach (LevelElement element in _elements)
                //{
                //    Console.Write(element.Draw);
                //}

            }
        }
    }
}

    



