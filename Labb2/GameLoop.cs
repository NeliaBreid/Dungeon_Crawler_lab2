
using System.Reflection;
using System;
using System.Runtime.ConstrainedExecution;
using System.Reflection.Emit;
using Labb2;
using System.Security.Cryptography.X509Certificates;

internal class GameLoop
{
    //private int turn = 0;
    //private bool isRunning = true;
    //private LevelData level;


    ////Player thePlayer = new Player();
    //GameLoop newGame = new GameLoop();






    public GameLoop() //det är bara en loop av spelet, konstruerar
    {
        //hantering av spelarens förflyttning

        //hantering av motståndarens förflyttning


    }






    //public void Start ()

    //{
    //    while (isRunning)   // metod här som innehåller en loop?
    //    {
    //        ConsoleKey key = Console.ReadKey().Key;


    //        //gör en konstruktor och initiera startpostition för spelaren och för fienderna, x y kordinater

    //        // Player.MovePlayer(key);
    //        //kolla om spelaren rör på sig

    //        // // 4. Uppdatera fiendernas drag
    //        // Update();

    //        //kolla om spelaren träffar på en vägg?

            
    

    //        foreach (Enemy enemy in level.Elements) //uppdaterar fienden
    //        {
    //            enemy.Update();
    //        }




    //        if (key == ConsoleKey.Escape)
    //        {
    //            isRunning = false;
    //        }
            
    //    }
       //för varje knapptryckning, flytta fienderna och spelaren?



        // hämtar input (som är knapptryckningar) som blir logik (t.ex flytta spelaren om spelaren inte är blockerad
        //, flytta fiender varje gång spelaren flyttar på sig.




        //En game loop är en loop som körs om och om igen medan spelet är igång, och i vårat fall kommer ett varv i loopen motsvaras av en omgång i spelet.
        //För varje varv i loopen inväntar vi att användaren trycker in en knapp; sedan utför vi spelarens drag, följt av datorns drag(uppdatera alla fiender),
        //innan vi loopar igen. Möjligtvis kan man ha en knapp(Esc) för att avsluta loopen/ spelet.

        //När spelaren/ fiender flyttar på sig behöver vi beräkna deras nya position och leta igenom alla vår LevelElements
        //för att se om det finns något annat objekt på den platsen man försöker flytta till.
        //Om det finns en vägg eller annat objekt(fiende/ spelaren) på platsen måste förflyttningen avbrytas och den tidigare positionen gälla.
        //Notera dock att om spelaren flyttar sig till en plats där det står en fiende så attackerar han denna(mer om detta längre ner).
        //Detsamma gäller om en fiende flyttar sig till platsen där spelaren står.
        //Fiender kan dock inte attackera varandra i spelet.

        //1. varje spelomgång blir ett objekt.
        //2. när vi gjort ett objekt av gameloop ska vi invänta en knapptryckning. när det skett en knapptryckning blir det spelarens drag
        //3. ett knapptryck defineras
        //4. min spelare flyttar sig, aktiveras fiendernas drag. 
        //5. 
    }
       
