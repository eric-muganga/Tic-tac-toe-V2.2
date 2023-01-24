using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe_V2._2
{
    internal class GameMechanics
    {
        private char player = 'O';
        private int input = 0;
        private bool inputIsCorrect = true;

        public int turns = 0;
        public char[,] playBoard = new char[,]
        {
            {' ', ' ', ' '},
            {' ', ' ', ' '},
            {' ', ' ', ' '}
        };

        //Display Display = new Display();

        public void NewGame()
        {
            do
            {
                if (player == 'X')
                {
                    player = 'O';
                    EnterXorO('X', input);
                }
                else if (player == 'O')
                {
                    player = 'X';
                    EnterXorO('O', input);
                }

                Board();

                CheckWinAndDraw();

                #region
                // Tests if the position on the board is taken
                do
                {
                    Console.Write($"\nPlayer {player}'s move > ");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("\nIllegal move! Try again.");
                    }

                    if ((input == 1) && (playBoard[0, 0] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 2) && (playBoard[0, 1] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 3) && (playBoard[0, 2] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 4) && (playBoard[1, 0] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 5) && (playBoard[1, 1] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 6) && (playBoard[1, 2] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 7) && (playBoard[2, 0] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 8) && (playBoard[2, 1] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else if ((input == 9) && (playBoard[2, 2] == ' '))
                    {
                        inputIsCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("\nIllegal move! Try again.");
                        inputIsCorrect = false;

                    }


                } while (!inputIsCorrect);
                #endregion

            } while (true);

        }

        public void EnterXorO(char playerSign, int input)
        {

            switch (input)
            {
                case 1:
                    playBoard[0, 0] = playerSign; break;
                case 2:
                    playBoard[0, 1] = playerSign; break;
                case 3:
                    playBoard[0, 2] = playerSign; break;
                case 4:
                    playBoard[1, 0] = playerSign; break;
                case 5:
                    playBoard[1, 1] = playerSign; break;
                case 6:
                    playBoard[1, 2] = playerSign; break;
                case 7:
                    playBoard[2, 0] = playerSign; break;
                case 8:
                    playBoard[2, 1] = playerSign; break;
                case 9:
                    playBoard[2, 2] = playerSign; break;
            }
        }

        public void CheckWinAndDraw()
        {
            #region
            //// check winning condition
            char[] playerChars = { 'X', 'O' };

            foreach (char playerChar in playerChars)
            {
                if (((playBoard[0, 0] == playerChar) && (playBoard[0, 1] == playerChar) && (playBoard[0, 2] == playerChar))
                  || ((playBoard[1, 0] == playerChar) && (playBoard[1, 1] == playerChar) && (playBoard[1, 2] == playerChar))
                  || ((playBoard[2, 0] == playerChar) && (playBoard[2, 1] == playerChar) && (playBoard[2, 2] == playerChar))
                  || ((playBoard[0, 0] == playerChar) && (playBoard[1, 0] == playerChar) && (playBoard[2, 0] == playerChar))
                  || ((playBoard[0, 1] == playerChar) && (playBoard[1, 1] == playerChar) && (playBoard[2, 1] == playerChar))
                  || ((playBoard[0, 2] == playerChar) && (playBoard[1, 2] == playerChar) && (playBoard[2, 2] == playerChar))
                  || ((playBoard[0, 0] == playerChar) && (playBoard[1, 1] == playerChar) && (playBoard[2, 2] == playerChar))
                  || ((playBoard[2, 0] == playerChar) && (playBoard[1, 1] == playerChar) && (playBoard[0, 2] == playerChar))
                  )
                {
                    if (playerChar == 'X')
                    {
                        Console.WriteLine("\nX has won ");
                    }
                    else
                    {
                        Console.WriteLine("\nO has won ");
                    }

                    Console.WriteLine("Press Enter To reset the The game");
                    Console.ReadKey();

                    ResetBoard();
                    break;
                }
                else if (turns == 10)
                {
                    Console.WriteLine("\nIt's a Draw");
                    Console.WriteLine("Press Enter To reset the The game");
                    Console.ReadKey();

                    ResetBoard();
                    break;
                }
            }

            #endregion
        }


        public void Board()
        {
            Console.Clear();
            Console.WriteLine($" {playBoard[0, 0]} | {playBoard[0, 1]} | {playBoard[0, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {playBoard[1, 0]} | {playBoard[1, 1]} |  {playBoard[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {playBoard[2, 0]} | {playBoard[2, 1]} |  {playBoard[2, 2]} ");
            turns++;
        }

        public void ResetBoard()
        {
            char[,] playBoardInitial = new char[,]
            {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
            };
            playBoard = playBoardInitial;
            Board();
            turns = 0;
        }

        public void AboutTheAuthor()
        {
            string firstName = "Eric";
            string lastName = "Muganga";
            string studentNumber = "pzx114029";
            string email = "mugangaeric2020@gmail.com";
            Console.WriteLine($"The author of this program is {firstName} {lastName}" +
                $" \n Student Number: {studentNumber} " +
                $" \n Email: {email}");
        }

        public void Quit()
        {
            Console.Write("Are you sure you want to quit? (Y/N) > ");
            string confirm = Console.ReadLine();
            if (confirm == "Y" || confirm == "y")
            {
                return;
            }

        }
    }
}
