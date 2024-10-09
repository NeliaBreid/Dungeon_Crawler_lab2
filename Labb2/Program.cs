
using Labb2;
using System.Drawing;

LevelData level = new LevelData();
string file = $"Levels\\Level1.txt";
Player player = level.Load(file);


GameLoop gameLoop = new GameLoop(level, player);
gameLoop.RunLoop();



Console.SetCursorPosition(1, Console.WindowHeight - 10);

