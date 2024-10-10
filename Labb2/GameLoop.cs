
using System.Reflection;
using System;
using System.Runtime.ConstrainedExecution;
using System.Reflection.Emit;
using Labb2;
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

            leveldata.PrintVisibleElements(player.Position, leveldata.Elements);

            player.MovePlayer(leveldata);

            UpdateEnemies();


            Console.SetCursorPosition(1, 18);
            Console.WriteLine(player.ToString());
            Console.SetCursorPosition(1, 18);


        }
    }

    private void UpdateEnemies()
    {
        List<Enemy> enemies = leveldata.Elements.OfType<Enemy>().ToList(); //OfType är LINQ

        foreach (Enemy enemy in enemies) //uppdaterar fienden, kan göra till en metod och lägga någonstans
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

