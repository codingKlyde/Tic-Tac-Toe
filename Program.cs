using System;





namespace Tic_Tac_Toe
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"{"*** TIC-TAC-TOE ***\n", -30}", Console.ForegroundColor = ConsoleColor.Blue);
            Console.ResetColor();
            
            
            Console.Write("[y/n] Start game?   ");
            char userInput = Console.ReadKey().KeyChar;
            
            if (userInput == 'y')
                StartGame();
            else
                Console.WriteLine("\n\n - BYE");
        }
        
        
        
        
        
        private static void StartGame()
        {
            char[,] board = new char[3, 3];

            const string xWinMessage = "\n\n-- Player X wins!";
            const string oWinMessage = "\n\n-- Player O wins!";

            const int z = 0;
            
            
            while (z <= 20)
            {
                Board(board);
                
                
                PlayerX(out int x1, out int x2, board, xWinMessage);

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


                PlayerO(out int o1, out int o2, board, oWinMessage);

                switch (o1)
                {
                    // ROW 1
                    case 0 when o2 == 0: board[0, 0] = 'O'; break;
                    case 0 when o2 == 1: board[0, 1] = 'O'; break;
                    case 0 when o2 == 2: board[0, 2] = 'O'; break;
                    // ROW 2
                    case 1 when o2 == 0: board[1, 0] = 'O'; break;
                    case 1 when o2 == 1: board[1, 1] = 'O'; break;
                    case 1 when o2 == 2: board[1, 2] = 'O'; break;
                    // ROW 3
                    case 2 when o2 == 0: board[2, 0] = 'O'; break;
                    case 2 when o2 == 1: board[2, 1] = 'O'; break;
                    case 2 when o2 == 2: board[2, 2] = 'O'; break;
                }
            }
        }

        
        
        
        
        private static void PlayerX(out int x1, out int x2, char[,] board, string xWinMessage)
        {
            // Player X winning condition
            // Horizontal
            if ((board[0, 0] == 'X') && (board[0, 1] == 'X') && (board[0, 2] == 'X') || 
                (board[1, 0] == 'X') && (board[1, 1] == 'X') && (board[1, 2] == 'X') ||
                (board[2, 0] == 'X') && (board[2, 1] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine(xWinMessage);
                Environment.Exit(1);
            }
            // Vertical
            else if ((board[0, 0] == 'X') && (board[1, 0] == 'X') && (board[2, 0] == 'X') ||
                     (board[0, 1] == 'X') && (board[1, 1] == 'X') && (board[2, 1] == 'X') ||
                     (board[0, 2] == 'X') && (board[1, 2] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine(xWinMessage);
                Environment.Exit(1);
            }
            // Diagonal
            else if ((board[0, 0] == 'X') && (board[1, 1] == 'X') && (board[2, 2] == 'X') ||
                     (board[0, 2] == 'X') && (board[1, 1] == 'X') && (board[2, 0] == 'X'))
            {
                Console.WriteLine(xWinMessage);
                Environment.Exit(1);
            }

            Console.Write("\n\n-- Player X's turn:   ");
            string[] xInput = Console.ReadLine().Split(' ');
            x1 = int.Parse(xInput[0]);
            x2 = int.Parse(xInput[1]);             
        }

        
        private static void PlayerO(out int o1, out int o2, char[,] board, string oWinMessage)
        {
            // Player O winning condition
            // Horizontal
            if ((board[0, 0] == 'O') && (board[0, 1] == 'O') && (board[0, 2] == 'O') ||
                (board[1, 0] == 'O') && (board[1, 1] == 'O') && (board[1, 2] == 'O') ||
                (board[2, 0] == 'O') && (board[2, 1] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine(oWinMessage);
                Environment.Exit(1);
            }
            // Vertical
            else if ((board[0, 0] == 'O') && (board[1, 0] == 'O') && (board[2, 0] == 'O') ||
                     (board[0, 1] == 'O') && (board[1, 1] == 'O') && (board[2, 1] == 'O') ||
                     (board[0, 2] == 'O') && (board[1, 2] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine(oWinMessage);
                Environment.Exit(1);
            }
            // Diagonal
            else if ((board[0, 0] == 'O') && (board[1, 1] == 'O') && (board[2, 2] == 'O') ||  
                     (board[0, 2] == 'O') && (board[1, 1] == 'O') && (board[2, 0] == 'O'))
            {
                Console.WriteLine(oWinMessage);
                Environment.Exit(1);
            }

            Console.Write("\n\n-- Player O's turn:   ");
            string[] oInput = Console.ReadLine().Split(' ');
            o1 = int.Parse(oInput[0]);
            o2 = int.Parse(oInput[1]);
        }
        
        
        
        

        // BOARD
        private static void Board(char[,] board)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[2, 0]} | {board[2, 1]} | {board[2, 2]}");
        }
    }
}