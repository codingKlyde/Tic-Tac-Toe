using System;





namespace Tic_Tac_Toe
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("[1] Start game");
            Console.WriteLine("----------");
            string userInput = Console.ReadLine();
            int userInputConv = Convert.ToInt32(userInput);                                                             // Converting to integer type
            

            switch (userInputConv)
            {
                case 1: StartGame(); break;
            }
        }
        
        
        
        
        
        private static void StartGame()
        {
            char[,] board = new char[3, 3];                                                                             // Create Tic-Tac-Toe board
            
            int[] xTurn = new int[2]; 
            int[] oTurn = new int[2]; 

            
            for (int i = 0; i < 100; i++)
            {
                bool xhasMoved = false;
                bool ohasMoved = false;
                int xCounter = 0, oCounter = 0;
                
                
                
                Console.WriteLine("\n");
                Console.WriteLine("{0} | {1} | {2}", board[0, 0], board[0, 1], board[0, 2]);
                Console.WriteLine("--+--+--");
                Console.WriteLine("{0} | {1} | {2}", board[1, 0], board[1, 1], board[1, 2]);
                Console.WriteLine("--+--+--");
                Console.WriteLine("{0} | {1} | {2}", board[2, 0], board[2, 1], board[2, 2]);

                xCounter = 1;
                if (xCounter != 0)
                {
                    PlayerX(xTurn);
                    xCounter = 0;
                    oCounter = 1;
                }
                
                if (oCounter != 0)
                {
                    PlayerO(oTurn);
                    oCounter = 0;
                    xCounter = 1;
                } 



                switch (xTurn[0])
                {
                    // ROW 1
                    case 0 when xTurn[1] == 0: board[0, 0] = 'X'; break;
                    case 0 when xTurn[1] == 1: board[0, 1] = 'X'; break;
                    case 0 when xTurn[1] == 2: board[0, 2] = 'X'; break;
                    // ROW 2
                    case 1 when xTurn[1] == 0: board[1, 0] = 'X'; break;
                    case 1 when xTurn[1] == 1: board[1, 1] = 'X'; break;
                    case 1 when xTurn[1] == 2: board[1, 2] = 'X'; break;
                    // ROW 3
                    case 2 when xTurn[1] == 0: board[2, 0] = 'X'; break;
                    case 2 when xTurn[1] == 1: board[2, 1] = 'X'; break;
                    case 2 when xTurn[1] == 2: board[2, 2] = 'X'; break;
                }
                
                switch (oTurn[0])
                {
                    // ROW 1
                    case 0 when oTurn[1] == 0: board[0, 0] = 'O'; break;
                    case 0 when oTurn[1] == 1: board[0, 1] = 'O'; break;
                    case 0 when oTurn[1] == 2: board[0, 2] = 'O'; break;
                    // ROW 2
                    case 1 when oTurn[1] == 0: board[1, 0] = 'O'; break;
                    case 1 when oTurn[1] == 1: board[1, 1] = 'O'; break;
                    case 1 when oTurn[1] == 2: board[1, 2] = 'O'; break;
                    // ROW 3
                    case 2 when oTurn[1] == 0: board[2, 0] = 'O'; break;
                    case 2 when oTurn[1] == 1: board[2, 1] = 'O'; break;
                    case 2 when oTurn[1] == 2: board[2, 2] = 'O'; break;
                }
            }
        }


        
        
        
        // Player X
        private static void PlayerX(int[] xTurn)
        {
            Console.Write("\n\n-- Player X's turn:   ");
            for (int j = 0; j < 2; j++) 
                xTurn[j] = Convert.ToInt32(Console.ReadLine());
        }
        
        // Player O
        private static void PlayerO(int[] oTurn)
        {
            Console.Write("\n\n-- Player O's turn:   ");
            for (int k = 0; k < 2; k++) 
                oTurn[k] = Convert.ToInt32(Console.ReadLine());
        }
    }
}