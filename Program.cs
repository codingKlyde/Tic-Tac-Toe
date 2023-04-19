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
            char r0c0 = board[0, 0], r0c1 = board[0, 1], r0c2 = board[0, 2];
            char r1c0 = board[1, 0], r1c1 = board[1, 1], r1c2 = board[1, 2];
            char r2c0 = board[2, 0], r2c1 = board[2, 1], r2c2 = board[2, 2];

            const string xWinMessage = "\n\n-- Player X wins!";
            const string oWinMessage = "\n\n-- Player O wins!";

            const int z = 15;
            
            
            while (z <= 15)
            {
                Console.Write("\n\n-- Player X's turn:   ");
                string[] xInput = Console.ReadLine().Split(' ');
                int x1 = int.Parse (xInput[0]);
                int x2 = int.Parse (xInput[1]);
                

                switch (x1)
                {
                    // ROW 1
                    case 0 when x2 == 0: r0c0 = 'X'; break;
                    case 0 when x2 == 1: r0c1 = 'X'; break;
                    case 0 when x2 == 2: r0c2 = 'X'; break;
                    // ROW 2
                    case 1 when x2 == 0: r1c0 = 'X'; break;
                    case 1 when x2 == 1: r1c1 = 'X'; break;
                    case 1 when x2 == 2: r1c2 = 'X'; break;
                    // ROW 3
                    case 2 when x2 == 0: r2c0 = 'X'; break;
                    case 2 when x2 == 1: r2c1 = 'X'; break;
                    case 2 when x2 == 2: r2c2 = 'X'; break;
                }
                
                
                Console.Write("\n\n-- Player O's turn:   ");
                string[] oInput = Console.ReadLine().Split(' ');
                int o1 = int.Parse (oInput[0]);
                int o2 = int.Parse (oInput[1]);
                
                
                switch (o1)
                {
                    // ROW 1
                    case 0 when o2 == 0: r0c0 = 'O'; break;
                    case 0 when o2 == 1: r0c1 = 'O'; break;
                    case 0 when o2 == 2: r0c2 = 'O'; break;
                    // ROW 2
                    case 1 when o2 == 0: r1c0 = 'O'; break;
                    case 1 when o2 == 1: r1c1 = 'O'; break;
                    case 1 when o2 == 2: r1c2 = 'O'; break;
                    // ROW 3
                    case 2 when o2 == 0: r2c0 = 'O'; break;
                    case 2 when o2 == 1: r2c1 = 'O'; break;
                    case 2 when o2 == 2: r2c2 = 'O'; break;
                }


                Board(r0c0, r0c1, r0c2, r1c0, r1c1, r1c2, r2c0, r2c1, r2c2);


                // Player X win conditions
                // Horizontal
                if ((r0c0 == 'X') && (r0c1 == 'X') && (r0c2 == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                else if ((r1c0 == 'X') && (r1c1 == 'X') && (r1c2 == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                else if ((r2c0 == 'X') && (r2c1 == 'X') && (r2c2 == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                // Vertical
                else if ((r0c0 == 'X') && (r1c0 == 'X') && (r2c0 == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                else if ((r0c1 == 'X') && (r1c1 == 'X') && (r2c1 == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                else if ((r0c2 == 'X') && (r1c2 == 'X') && (r2c2 == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                // Diagonal
                else if ((r0c0 == 'X') && (r1c1 == 'X') && (r2c2 == 'X') ||  (r2c2 == 'X') && (r1c1 == 'X') && (r0c0 == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
                else if ((r0c2 == 'X') && (r1c1 == 'X') && (r2c0 == 'X') || (r2c0 == 'X') && (r1c1 == 'X') && (r0c2 == 'X'))
                {
                    Console.WriteLine(xWinMessage);
                    return;
                }
            }
        }

        
        
        

        // BOARD
        private static void Board(char r0c0, char r0c1, char r0c2, char r1c0, char r1c1, char r1c2, char r2c0, char r2c1, char r2c2)
        {
            Console.WriteLine("\n");
            Console.WriteLine("{0} | {1} | {2}", r0c0, r0c1, r0c2);
            Console.WriteLine("--+---+--");
            Console.WriteLine("{0} | {1} | {2}", r1c0, r1c1, r1c2);
            Console.WriteLine("--+---+--");
            Console.WriteLine("{0} | {1} | {2}", r2c0, r2c1, r2c2);
        }
    }
}