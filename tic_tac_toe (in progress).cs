using System;
using System.Linq;

namespace tic_tac_toe__in_progress_
{
    class Program
    {
        static string[] board = {"-", "-", "-",
                              "-", "-", "-",
                              "-", "-", "-",};
        static bool game_still_going = true;
        static string winner = null;
        static string current_player = "x";

        static void Main(string[] args)
        {
            PlayGame();
        }

        static void DisplayBoard()
        {
            Console.WriteLine(board[0] + " | " + board[1] + " | " + board[2]);
            Console.WriteLine(board[3] + " | " + board[4] + " | " + board[5]);
            Console.WriteLine(board[6] + " | " + board[7] + " | " + board[8]);

        }

        static void PlayGame()
        {
            DisplayBoard();
            while (game_still_going)
            {
                HandleTurn(current_player);
                CheckIsGameOver();
                FlipPlayer();
            }

            if (winner == "x" || winner == "o")
                Console.WriteLine("The winner is: " + winner);
            else if (winner == null)
                Console.WriteLine("We have a tie :|");
        }

        static string FlipPlayer()
        {
            if (current_player == "x")
                current_player = "o";
            else if (current_player == "o")
                current_player = "x";
            return current_player;
        }

        static void CheckIsGameOver()
        {
            CheckForWinner();
            CheckIfTie();
        }

        static void CheckIfTie()
        {
            if (!board.Contains("-"))
                game_still_going = false;
        }

        static void CheckForWinner()
        {
            
        }

        static void CheckRows()
        {

        }

        static void CheckColumns()
        {
            
        }

        static void CheckDiagonals()
        {
            
        }

        static void HandleTurn(string current_player)
        {
            Console.WriteLine(current_player + "'s turn.");
            Console.Write("Choose a position from 1-9: ");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int position = int.Parse(Console.ReadLine());
            bool valid = false;
            while (!valid)
            {
                while (!numbers.Contains(position))
                {
                    Console.Write("Choose a position from 1-9: ");
                }
                position = position - 1;

                if (board[position] == "-")
                    valid = true;
                else
                    Console.WriteLine("You can't go there. Go again.");
            }

            board[position] = current_player;
            DisplayBoard();
        }
    }
}
