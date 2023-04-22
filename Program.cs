using System;





namespace Tic_Tac_Toe
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("[y/n] Start game?   ");
            char userInput = Console.ReadKey().KeyChar;
            

            if (userInput == 'y')
                StartGame();
            else
                return;
        }
        
        
        
        
        
        private static void StartGame()
        {
            char[,] board = new char[3, 3];

            const string xWinMessage = "\n\n-- Player X wins!";
            const string oWinMessage = "\n\n-- Player O wins!";

            const int z = 15;
            
            
            while (z <= 15)
            {
                int x1, x2, o1, o2;
                
                PlayerX(out x1, out x2);
                

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


                PlayerO(out o1, out o2);
                 
                
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


                Board(board);


                // Player X win conditions
                // Horizontal
                if ((board[0, 0] == 'X') && (board[0, 1] == 'X') && (board[0, 2] == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                else if ((board[1, 0] == 'X') && (board[1, 1] == 'X') && (board[1, 2] == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                else if ((board[2, 0] == 'X') && (board[2, 1] == 'X') && (board[2, 2] == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                // Vertical
                else if ((board[0, 0] == 'X') && (board[1, 0] == 'X') && (board[2, 0] == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                else if ((board[0, 1] == 'X') && (board[1, 1] == 'X') && (board[2, 1] == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                else if ((board[0, 2] == 'X') && (board[1, 2] == 'X') && (board[2, 2] == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                // Diagonal
                else if ((board[0, 0] == 'X') && (board[1, 1] == 'X') && (board[2, 2] == 'X') ||  (board[2, 2] == 'X') && (board[1, 1] == 'X') && (board[0, 0] == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                else if ((board[0, 2] == 'X') && (board[1, 1] == 'X') && (board[2, 0] == 'X') || (board[2, 0] == 'X') && (board[1, 1] == 'X') && (board[0, 2] == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
            }
        }

        
        
        
        
        private static void PlayerX(out int x1, out int x2)
        {
            Console.Write("\n\n-- Player X's turn:   ");
            string[] xInput = Console.ReadLine().Split(' ');
            x1 = int.Parse(xInput[0]);
            x2 = int.Parse(xInput[1]);
        }

        private static void PlayerO(out int o1, out int o2)
        {
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