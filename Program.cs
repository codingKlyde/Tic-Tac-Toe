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
            char[,] board = new char[3, 3];                                                                             // Create Tic-Tac-Toe board

            int z = 15;
            

            while (z <= 15)
            {
               


                Console.Write("\n\n-- Player X's turn:   ");
                string[] xInput = Console.ReadLine().Split(' ');
                int x1 = int.Parse (xInput[0]);
                int x2 = int.Parse (xInput[1]);



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
                
                
                
                Console.Write("\n\n-- Player O's turn:   ");
                string[] oInput = Console.ReadLine().Split(' ');
                int o1 = int.Parse (oInput[0]);
                int o2 = int.Parse (oInput[1]);
              
                
                
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
                
                
                Console.WriteLine("");
                Console.WriteLine("{0} | {1} | {2}", board[0, 0], board[0, 1], board[0, 2]);
                Console.WriteLine("--+---+--");
                Console.WriteLine("{0} | {1} | {2}", board[1, 0], board[1, 1], board[1, 2]);
                Console.WriteLine("--+---+--");
                Console.WriteLine("{0} | {1} | {2}", board[2, 0], board[2, 1], board[2, 2]);
            }
        }
    }
}