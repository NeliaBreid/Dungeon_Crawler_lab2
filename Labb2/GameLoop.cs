
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


        //hantering av spelarens förflyttning

        //hantering av motståndarens förflyttning

    }
 
    public void RunLoop()
    {

        while (true)
        {
            // vänta tills användaren trycker på en knapp med / eller inte

            // var gameLoop = new GameLoop();
            player.MovePlayer(leveldata); //spelaren rör på sig

            //gör en egen metod för allt (updatera fienderna)

            UpdateEnemies();


            // kolla om man gått på en fienden

        }
    }


    private void UpdateEnemies()
    {
        List<Enemy> enemies = leveldata.Elements.OfType<Enemy>().ToList(); //OfType är LINQ

        foreach (Enemy enemy in enemies) //uppdaterar fienden, kan göra till en metod och lägga någonstans
        {
            enemy.Draw();
            enemy.Update(enemy.Position, leveldata);
            //(enemy.Position);

        }

    }

    //När spelaren/ fiender flyttar på sig behöver vi beräkna deras nya position och leta igenom alla vår LevelElements
    //för att se om det finns något annat objekt på den platsen man försöker flytta till.
    //Om det finns en vägg eller annat objekt(fiende/ spelaren) på platsen måste förflyttningen avbrytas och den tidigare positionen gälla.
    //Notera dock att om spelaren flyttar sig till en plats där det står en fiende så attackerar han denna(mer om detta längre ner).
    //Detsamma gäller om en fiende flyttar sig till platsen där spelaren står.
    //Fiender kan dock inte attackera varandra i spelet.

    // Fredrik:
    // Har du kollat på uppgift 13 i övningsuppgifterna för funktioner? Den är i princip samma sak som du behöver för labben för att flytta spelaren.
    // Datorns drag behöver en metod för att loopa igenom alla fiender och anropa Update() på allihop. Du behöver då implementera Update() i Rat respektive Snake så att de flyttar sig på det sätt som beskrivs i labben.
    //Sen behöver både player och fiender kolla vad som finns på den plats de försöker flytta till,  så de inte kan gå igenom t.ex väggar. Du kan försöka skriva en metod GetLevelElementAt(int x, int y) som kollar igenom alla objekt i LevelData.Elements och returnera det objekt som finns på positionen (x, y), alternativt returnerar null om inget av objekten finns där.
    //Då kan du sedan kolla objektet du fått tillbaks om det är en Wall, Rat.. etc.

}

