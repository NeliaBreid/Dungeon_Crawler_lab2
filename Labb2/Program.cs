
using Labb2;
using System.Drawing;

LevelData level = new LevelData();
string file = $"Levels\\Level1.txt";
level.Load(file);

//StructPosition p1 = new StructPosition(3,4);
//Console.WriteLine(p1.DistanceToOrigin(p1));


var player = new Player(new StructPosition(3, 4));
player.Draw();
player.MovePlayer();

do //för varje varv instanseras ett nytt objekt av gameloop(var)
{

    var gameLoop = new GameLoop();
    player.MovePlayer(); //spelaren rör på sig
    foreach (Enemy enemy in level.Enemies) //uppdaterar fienden, kan göra till en metod och lägga någonstans
         {
        
            enemy.Update(enemy.Position);
        
        
         }
}
while (true);

Console.SetCursorPosition(1, Console.WindowHeight - 10);


//StructPosition p1 = new StructPosition(3, 4);
//Console.WriteLine(p1); // Skriv ut: Point(3, 4)

//Console.WriteLine($"Distance to origin: {p1.DistanceToOrigin()}");
