/***
 * TO DO: SCORING IS BROKEN, SCORE DOESN'T ADD UP
 */
using System;


namespace Tic_Tac_Toe
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // Declare 3x3 board
            const int row = 3, col = 3;
            char[,] board = new char[row, col];
            
            
            Console.WriteLine($"{"*** TIC-TAC-TOE ***\n"}");
            
            
            Console.Write("[y/n] Start game?   ");
            char userInput = Console.ReadKey().KeyChar;

            if (userInput == 'y')
            {
                StartGame(board);
            }
            else
                Console.WriteLine("\n\n-- BYE");
        }
        
        
        // START GAME
        private static void StartGame(char[,] board)
        {
            // Clears board
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    board[i, j] = '\0';
            }
            
            while (true)
            {
                Console.WriteLine("\n");
                Board(board);
                PlayerX(board);                                                                                     
                WinningCondition(board);                                                

                Board(board);
                PlayerO(board);
                WinningCondition(board);
            }
        }

        
        

        
        // PLAYER X INPUT
        private static void PlayerX(char[,] board)
        {
            // Get two inputs separate by space (row, column)
            Console.Write("\n-- Player X's turn:   ");
            string[] xInput = Console.ReadLine().Split(' ');
            int x1 = int.Parse(xInput[0]);
            int x2 = int.Parse(xInput[1]);
            
            // Checks if the input is between from 1 to 2
            if ((x1 >= 0 && x1 <= 2) && (x2 >= 0 && x2 <= 2))                                                   
            {
                // Checks if the selected cell is empty
                if (board[x1, x2] == '\0')                                                                      
                {
                    switch (x1)
                    {
                        // ROW 1
                        case 0 when x2 == 0: board[0, 0] = 'X'; break;
                        case 0 when x2 == 1: board[0, 1] = 'X'; break;
                        case 0 when x2 == 2: board[0, 2] = 'X'; break;
                        // ROW 2
                        case 1 when x2 == 0: board[1, 0] = 'X'; break;
                        case 1 when x2 == 1: board[1, 1] = 'X'; break;
                        case 1 when x2 == 2: board[1, 2] = 'X'; break;
                        // ROW 3
                        case 2 when x2 == 0: board[2, 0] = 'X'; break;
                        case 2 when x2 == 1: board[2, 1] = 'X'; break;
                        case 2 when x2 == 2: board[2, 2] = 'X'; break;
                    }
                }
                else
                    Console.WriteLine("\n-- nCell occupied.");
            }
            else
                Console.WriteLine("\n-- Invalid row or column.");
        }

        
        // PLAYER O INPUT
        private static void PlayerO(char[,] board)
        {
            // Gets two inputs separate by space (row, column)
            Console.Write("\n-- Player O's turn:   ");
            string[] oInput = Console.ReadLine().Split(' ');
            int o1 = int.Parse(oInput[0]);
            int o2 = int.Parse(oInput[1]);


            // Checks if the input is between from 1 to 2
            if ((o1 >= 0 && o1 <= 2) && (o2 >= 0 && o2 <= 2)) 
            {
                // Checks if selected cell is empty
                if (board[o1, o2] == '\0')                                                                            
                {
                    switch (o1)
                    {
                        // Row 1
                        case 0 when o2 == 0: board[0, 0] = 'O'; break;
                        case 0 when o2 == 1: board[0, 1] = 'O'; break;
                        case 0 when o2 == 2: board[0, 2] = 'O'; break;
                        // Row 2
                        case 1 when o2 == 0: board[1, 0] = 'O'; break;
                        case 1 when o2 == 1: board[1, 1] = 'O'; break;
                        case 1 when o2 == 2: board[1, 2] = 'O'; break;
                        // Row 3
                        case 2 when o2 == 0: board[2, 0] = 'O'; break;
                        case 2 when o2 == 1: board[2, 1] = 'O'; break;
                        case 2 when o2 == 2: board[2, 2] = 'O'; break;
                    }
                }
                else
                    Console.WriteLine("\nCell occupied.");
            }
            else
                Console.WriteLine("\nInvalid row or column.");
        }




        // WINNING CONDITION
        private static void WinningCondition(char[,] board)
        {
            int playerXscore = 0;
            int playerOscore = 0;
            
            const string xWinMessage = "\n\n== Player X wins!";
            const string oWinMessage = "\n\n== Player O wins!";
            const string drawMessage = "\n\n== Tie!";
            
  
            // Player X
            if (// Horizontal
                (board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X') ||
                (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X') ||
                (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X') ||
                // Vertical
                (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X') ||
                (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X') ||
                (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X') ||
                // Diagonal
                (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X') ||
                (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X'))
            {
                playerXscore++;          // Add 1 point for player X
                Console.WriteLine(xWinMessage);
                Console.WriteLine($"== X = {playerXscore} | O = {playerOscore}");

                StartGame(board);
            }
            
            
            // Player O
            if (// Horizontal
                (board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O') ||
                (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O') ||
                (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O') ||
                // Vertical
                (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O') ||
                (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O') ||
                (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O') ||
                // Diagonal
                (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O') ||
                (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O'))
            {
                playerOscore++;          // Add 1 point for player O
                Console.WriteLine(oWinMessage);
                Console.WriteLine($"== X = {playerXscore} | O = {playerOscore}");

                StartGame(board);
            }
            
            
            // Checks if all cells are occupied without a winner
            if ((board[0, 0]) != '\0' && (board[0, 1]) != '\0' && (board[0, 2]) != '\0' &&
                (board[1, 0]) != '\0' && (board[1, 1]) != '\0' && (board[1, 2]) != '\0' &&
                (board[2, 0]) != '\0' && (board[2, 1]) != '\0' && (board[2, 2]) != '\0')
            {
                Console.WriteLine(drawMessage);
                Console.WriteLine($"== X = {playerXscore} | O = {playerOscore}");
                    
                StartGame(board);
            }
        }
        
        
        
        
        
        // BOARD
        private static void Board(char[,] board)
        {
            // Displays the board
            Console.WriteLine("");
            Console.WriteLine($"{board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[2, 0]} | {board[2, 1]} | {board[2, 2]}");
        }
    }
}