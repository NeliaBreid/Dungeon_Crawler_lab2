﻿
using Labb2;
using System.Drawing;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Player : LevelElement
{
    public Player(StructPosition Position) : base(Position)
    {
        Icon = '@';
        ForegroundColor = ConsoleColor.White;
    }

    public void MovePlayer()
    {
        
        
            var positionX = Position.X;
            var positionY = Position.Y;

            Console.CursorVisible = false;

            ConsoleKey key = Console.ReadKey().Key;

        switch (key)
        {
            case ConsoleKey.UpArrow:
                positionY -= 1;
                break;
            case ConsoleKey.DownArrow:
                positionY += 1;
                break;
            case ConsoleKey.LeftArrow:
                positionX -= 1;
                break;
            case ConsoleKey.RightArrow:
                positionX += 1;
                break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    return; 
        }

   
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(' ');

            Position = new StructPosition(positionX, positionY);
            
        Draw();
        
    }
}























            // -----------chatgtplösning---------
            ////måste ha tillgång till @ som ligger i en lista i klassen Leveldata
            ////måste ha startposition för @
            //int x = 4;
            //int y = 3;


            ////

            //ConsoleKeyInfo keyInfo = Console.ReadKey(true); //läser tangenten

            //while (true)
            //{
            //    Console.SetCursorPosition(x, y);
            //    Console.Write("@");

            //   // Console.CursorVisible = false;

            //    switch (keyInfo.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //          //  y = Math.Max(0, y - 1); // Flytta upp (minska y) om möjligt
            //            break;
            //        case ConsoleKey.DownArrow:
            //           // y = Math.Min(Console.WindowHeight - 1, y + 1); // Flytta ned (öka y)
            //            break;
            //        case ConsoleKey.LeftArrow:
            //           // x = Math.Max(0, x - 1); // Flytta vänster (minska x)
            //            break;
            //        case ConsoleKey.RightArrow:
            //          //  x = Math.Min(Console.WindowWidth - 1, x + 1); // Flytta höger (öka x)
            //            break;
            //        case ConsoleKey.Escape:
            //            return; // Avsluta spelet om Escape trycks
            //    }

        
    



