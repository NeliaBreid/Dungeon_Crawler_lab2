using Labb2;
using System.Runtime.CompilerServices;

LevelData level = new LevelData();
string file = $"Levels\\Level1.txt";
level.Load(file); //metod för att läsa in filen

var player = new Player(new StructPosition(3, 4));
player.Draw();
player.MovePlayer();

int totalElements = level.Elements.Count; // 304 element i listan
//Console.WriteLine(totalElements);


//Rat rat = new Rat(3,4);
//Snake snake = new Snake(5,6);
//Wall wall = new Wall(4,6);
//rat.Draw();
//snake.Draw();
//wall.Draw();



