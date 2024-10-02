
LevelData level = new LevelData();
string file = $"Levels\\Level1.txt";
level.Load(file);

int totalElements = level.Elements.Count; // 304 element i listan
Console.WriteLine(totalElements);



//foreach (LevelElement element in level.Elements)
//{
//    element.Draw();
//}

//Rat rat = new Rat(3,4);
//Snake snake = new Snake(5,6);
//Wall wall = new Wall(4,6);
//rat.Draw();
//snake.Draw();
//wall.Draw();

// sparar en textfil i mitt system
//string textfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Levels", "Level1.txt");



//if (File.Exists(textfile)) //om filen finns, läser in filen.
//{
//    Console.WriteLine(File.ReadAllText(textfile)); // Läs in, skriv ut
//}

