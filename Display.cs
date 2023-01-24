/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe_V2._2
{
    internal class Display
    {
        //GameMechanics GameMec = new GameMechanics();
        // Board function which creats board
        public void Board()
        {
            Console.Clear();
            Console.WriteLine($" {playBoard[0, 0]} | {playBoard[0, 1]} | {playBoard[0, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {playBoard[1, 0]} | {playBoard[1, 1]}  |  {playBoard[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {playBoard[2, 0]} | {playBoard[2, 1]}  |  {playBoard[2, 2]} ");
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

*/