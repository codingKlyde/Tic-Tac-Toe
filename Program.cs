using System;





namespace Tic_Tac_Toe
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // 3x3 board
            const int row = 3, col = 3;
            char[,] board = new char[row, col];
            
            
            Console.WriteLine($"{"*** TIC-TAC-TOE ***\n"}");
            
            
            Console.Write("[y/n] Start game?   ");
            char userInput = Console.ReadKey().KeyChar;

            if (userInput == 'y')
            {
                while (true)
                {
                    Board(board);                                                                                      
                    PlayerX(board);                                                                                     
                    WinningCondition(board);                                                

                    Board(board);
                    PlayerO(board);
                    WinningCondition(board);
                }
            }
            else
                Console.WriteLine("\n\n - BYE");
        }
        

        
        
   
        // PLAYER X INPUT
        private static void PlayerX(char[,] board)
        {
            // Get two inputs separate by space (row, column)
            Console.Write("\n-- Player X's turn:   ");
            string[] xInput = Console.ReadLine().Split(' ');
            int x1 = int.Parse(xInput[0]);
            int x2 = int.Parse(xInput[1]);

            
            if ((x1 >= 0 && x1 <= 2) && (x2 >= 0 && x2 <= 2))                                                   // Check if the input is between from 1 to 2
            {
                if (board[x1, x2] == '\0')                                                                      // Check if the cell is empty
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
                    Console.WriteLine("\nCell occupied.");
            }
            else
                Console.WriteLine("\nInvalid row or column.");
        }

        
        // PLAYER O INPUT
        private static void PlayerO(char[,] board)
        {
            // Get two inputs separate by space (row, column)
            Console.Write("\n-- Player O's turn:   ");
            string[] oInput = Console.ReadLine().Split(' ');
            int o1 = int.Parse(oInput[0]);
            int o2 = int.Parse(oInput[1]);


            if ((o1 >= 0 && o1 <= 2) && (o2 >= 0 && o2 <= 2)) 
            {
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
            const string xWinMessage = "\n\n-- Player X wins!";
            const string oWinMessage = "\n\n-- Player O wins!";
            const string drawMessage = "\n\n-- Draw!";
            
            
            // Player X winning condition
            // Horizontal
            if ((board[0, 0] == 'X') && (board[0, 1] == 'X') && (board[0, 2] == 'X') || 
                (board[1, 0] == 'X') && (board[1, 1] == 'X') && (board[1, 2] == 'X') ||
                (board[2, 0] == 'X') && (board[2, 1] == 'X') && (board[2, 2] == 'X'))
            {
                Board(board);
                Console.WriteLine(xWinMessage);
                Environment.Exit(1);
            }
            // Vertical
            else if ((board[0, 0] == 'X') && (board[1, 0] == 'X') && (board[2, 0] == 'X') ||
                     (board[0, 1] == 'X') && (board[1, 1] == 'X') && (board[2, 1] == 'X') ||
                     (board[0, 2] == 'X') && (board[1, 2] == 'X') && (board[2, 2] == 'X'))
            {
                Board(board);
                Console.WriteLine(xWinMessage);
                Environment.Exit(1);
            }
            // Diagonal
            else if ((board[0, 0] == 'X') && (board[1, 1] == 'X') && (board[2, 2] == 'X') ||
                     (board[0, 2] == 'X') && (board[1, 1] == 'X') && (board[2, 0] == 'X'))
            {
                Board(board);
                Console.WriteLine(xWinMessage);
                Environment.Exit(1);
            }
            
            
            // Player O winning condition
            // Horizontal
            if ((board[0, 0] == 'O') && (board[0, 1] == 'O') && (board[0, 2] == 'O') ||
                (board[1, 0] == 'O') && (board[1, 1] == 'O') && (board[1, 2] == 'O') ||
                (board[2, 0] == 'O') && (board[2, 1] == 'O') && (board[2, 2] == 'O'))
            {
                Board(board);
                Console.WriteLine(oWinMessage);
                Environment.Exit(1);
            }
            // Vertical
            else if ((board[0, 0] == 'O') && (board[1, 0] == 'O') && (board[2, 0] == 'O') ||
                     (board[0, 1] == 'O') && (board[1, 1] == 'O') && (board[2, 1] == 'O') ||
                     (board[0, 2] == 'O') && (board[1, 2] == 'O') && (board[2, 2] == 'O'))
            {
                Board(board);
                Console.WriteLine(oWinMessage);
                Environment.Exit(1);
            }
            // Diagonal
            else if ((board[0, 0] == 'O') && (board[1, 1] == 'O') && (board[2, 2] == 'O') ||  
                     (board[0, 2] == 'O') && (board[1, 1] == 'O') && (board[2, 0] == 'O'))
            {
                Board(board);
                Console.WriteLine(oWinMessage);
                Environment.Exit(1);
            }
            
            // Full
            if ((board[0, 0]) != '\0' && (board[0, 1]) != '\0' && (board[0, 2]) != '\0' &&
                (board[1, 0]) != '\0' && (board[1, 1]) != '\0' && (board[1, 2]) != '\0' &&
                (board[2, 0]) != '\0' && (board[2, 1]) != '\0' && (board[2, 2]) != '\0')
            {
                Board(board);
                Console.WriteLine(drawMessage);
                Environment.Exit(1);
            }
        }
        
        
        
        
        
        // BOARD
        private static void Board(char[,] board)
        {
            // Displays the board
            Console.WriteLine("\n");
            Console.WriteLine($"{board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[2, 0]} | {board[2, 1]} | {board[2, 2]}");
        }
    }
}