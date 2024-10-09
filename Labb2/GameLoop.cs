
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

    public GameLoop(LevelData data, Player player) //det är bara en loop av spelet, konstruerar spelet m. konstruktor
    {
        this.leveldata = data;
        this.player = player;

    }
 
    public void RunLoop()
    {

        while (true)
        {
            leveldata.RenderVisibleElements(player.Position, leveldata.Elements);

            player.MovePlayer(leveldata); //spelaren rör på sig

            UpdateEnemies();

        }
    }


    private void UpdateEnemies()
    {
        List<Enemy> enemies = leveldata.Elements.OfType<Enemy>().ToList(); //OfType är LINQ

        foreach (Enemy enemy in enemies) //uppdaterar fienden, kan göra till en metod och lägga någonstans
        {
            enemy.Draw();
            enemy.Update(enemy.Position, leveldata);
            

        }

    }

}

