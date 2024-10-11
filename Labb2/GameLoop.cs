
using System.Reflection;
using System;
using System.Runtime.ConstrainedExecution;
using System.Reflection.Emit;

using System.Security.Cryptography.X509Certificates;

internal class GameLoop
{
    private LevelData leveldata;
    private Player player;



    public GameLoop(LevelData data, Player player)
    {
        this.leveldata = data;
        this.player = player;

    }

    public void RunLoop()
    {

        while (true)
        {

            leveldata.PrintVisibleSurrondings(player.Position, leveldata.Elements);

            player.MovePlayer(leveldata);

            UpdateEnemies();

            Console.SetCursorPosition(1, 18);
            Console.WriteLine(player.ToString());

        }
    }

    private void UpdateEnemies()
    {
        List<Enemy> enemies = leveldata.Elements.OfType<Enemy>().ToList(); 

        foreach (Enemy enemy in enemies) 
        {
            if (enemy is Rat)
            {
                var rat = (Rat)enemy;
                rat.Update(enemy.Position, leveldata);


            }
            else if (enemy is Snake)
            {
                var snake = (Snake)enemy;
                snake.Update(player.Position, leveldata);
            }

        }
    }

}

