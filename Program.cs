using System;
using System.Numerics;
using Tic_tac_toe_V2._2;

namespace Tic_tac_toe_V21
{
    enum MenuOption
    {
        NewGame = 1,
        AboutAuthor = 2,
        Quit = 3,
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            GameMechanics GameMec = new GameMechanics();
            //Display display = new Display();

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. New game");
            Console.WriteLine("2. About the author");
            Console.WriteLine("3. Quit");
            Console.WriteLine();
            Console.Write("\nEnter your choice: ");



            int choiceMenu = int.Parse(Console.ReadLine());
            MenuOption option = (MenuOption)choiceMenu;


            switch (option)
            {
                case MenuOption.NewGame:
                    // New game
                    
                    GameMec.NewGame();
                    break;
                case MenuOption.AboutAuthor:
                    // About the author
                    
                    GameMec.AboutTheAuthor();
                    break;
                case MenuOption.Quit:
                    // Quit
                    GameMec.Quit();
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();



        }


    }
}