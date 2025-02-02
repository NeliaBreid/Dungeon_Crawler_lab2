﻿

internal class Player : LevelElement
{
    public int Health { get; set; }
    public static int Turn {  get; set; }
    public string Name { get; set; }
    public Dice AttackDice { get; set; }
    public Dice DefenceDice { get; set; }
    public bool IsVisible { get; set; }
    public Player(StructPosition Position) : base(Position)
    {
        Icon = '@';
        ForegroundColor = ConsoleColor.White;
        Health = 100;
        Name = "Player";
        IsVisible = true;
        AttackDice = new Dice(2, 6, 2);
        DefenceDice = new Dice(2, 6, 0);
    }

    public void MovePlayer(LevelData levelData)
    {
        Turn++;

        var posX = Position.X;
        var posY = Position.Y;



        Console.CursorVisible = false;

        ConsoleKey key = Console.ReadKey().Key;

        switch (key)
        {
            case ConsoleKey.UpArrow:
                posY -= 1;
                break;
            case ConsoleKey.DownArrow:
                posY += 1;
                break;
            case ConsoleKey.LeftArrow:
                posX -= 1;
                break;
            case ConsoleKey.RightArrow:
                posX += 1;
                break;
            case ConsoleKey.Escape:
                Environment.Exit(0);
                return;
        }

        var previousPlayerPosition = new StructPosition(Position.X, Position.Y);

        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(' ');




        var newPlayerPosition = new StructPosition(posX, posY);

        var element = isElement(newPlayerPosition, levelData.Elements);

        if (element != null)
        {
            
            if (element is Rat rat && IsVisible)
            {

                PlayerAttacksEnemy(this, rat);
                EnemyattacksPlayer(rat, this);

            }
            else if (element is Snake snake && IsVisible)
            {

                PlayerAttacksEnemy(this, snake);
                EnemyattacksPlayer(snake, this);

            }
        }

        else 
        {
            Position = new StructPosition(posX, posY); 
            
        }

        if (IsVisible)
        {
            Draw();
            
        }

    }
    public LevelElement? isElement(StructPosition position, List<LevelElement> levelElements)
    {

        foreach (LevelElement element in levelElements)
        {

            if (element.Position.Equals(position))
            {

                return element;

            }
        }
        return null;
    }
    public override string ToString()
    {
        string playerString = $"{Name} has {Health} HP left. Turn: {Turn}.";
        return playerString;
    }
    public static void PlayerAttacksEnemy(Player player, Enemy enemy) 
    {
        int attackPoints = player.AttackDice.Throw();
        int defensePoints = enemy.DefenceDice.Throw();
        int damage = attackPoints - defensePoints;

        if (damage > 0)
        {
            enemy.Health -= damage;
            Console.SetCursorPosition(1, 20);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(1, 20);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{player.Name} attacks {enemy.Name} causing {damage} damage! {enemy.Name} has {enemy.Health} HP left.");
            Console.SetCursorPosition(player.Position.X, player.Position.Y);
        }
        else
        {
            Console.SetCursorPosition(1, 20);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(1, 20);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{player.Name} attacks but {enemy.Name} blocks the attack!");
            Console.SetCursorPosition(player.Position.X, player.Position.Y);
        }

       
        if (enemy.Health <= 0)
        {
            Console.SetCursorPosition(1, 20);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(1, 20);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{enemy.Name} is defeated!");
            enemy.IsVisible = false;
            return;
        }

        if (player.Health <= 0)
        {
            Console.WriteLine("GAME OVER!");
            Environment.Exit(0);
        }

    }
    public void EnemyattacksPlayer(Enemy enemy, Player player) 
    {

        int attackPoints = enemy.AttackDice.Throw();
        int defensePoints = player.DefenceDice.Throw();
        int damage = attackPoints - defensePoints;


        if (damage > 0)
        {
            Console.SetCursorPosition(1, 21);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(1, 21);
            player.Health -= damage;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{enemy.Name} attacks {player.Name} causing {damage} damage! {player.Name} has {player.Health} HP left.");
           
        }
        else
        {

            Console.SetCursorPosition(1, 21);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(1, 21);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{enemy.Name} attacks but {player.Name} blocks the attack!");
        }


        if (enemy.Health <= 0)
        {
            Console.SetCursorPosition(1, 21);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(1, 21);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{enemy.Name} is defeated!");

        }
        if (player.Health <= 0)
        {
            Console.WriteLine("GAME OVER!");
            Environment.Exit(0);
        }
    }
}
