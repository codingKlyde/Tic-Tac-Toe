/*
Problem Statement:
    Write a program that allows two players to play Tic Tac Toe.

Input:
    The input consists of the player's moves, one move per line. Each move consists of two integers separated by a space, representing the row and column of the cell where the player wants to make their move. The first player uses the symbol 'X', and the second player uses the symbol 'O'.

Output:
    After each move, the program should print the current state of the Tic Tac Toe board. If the game is over (either a player wins or the board is filled up with no winner), the program should print the final state of the board and announce the winner (if there is one) or a tie.

Limits:
    The board is a 3x3 grid.
    Each move is a pair of integers between 1 and 3 (inclusive), representing the row and column of the cell where the player wants to make their move.
    Each move must be to an empty cell.
    There are at most 9 moves in a game (if the board is filled up before any player wins, the game is over).
    
Notes:
    There may be additional test cases not listed in the specification, and your program must produce the correct output for these test cases.


Sample Input/Output #1:
Player X's turn:
1 1

X| | 
-+-+-
 | | 
-+-+-
 | | 

Player O's turn:
2 2

X| | 
-+-+-
 |O| 
-+-+-
 | | 

Player X's turn:
3 3

X| | 
-+-+-
 |O| 
-+-+-
 | |X

Player O's turn:
3 2

X| | 
-+-+-
 |O| 
-+-+-
 |O|X

Player X's turn:
2 1

X| | 
-+-+-
X|O| 
-+-+-
 |O|X

Player O's turn:
1 3

X| |O
-+-+-
X|O| 
-+-+-
 |O|X

Player X's turn:
2 3

X| |O
-+-+-
X|O|X
-+-+-
 |O|X

Game over! The winner is X.
X| |O
-+-+-
X|O|X
-+-+-
 |O|X

Sample Input/Output #2:
Player X's turn:
1 1

X| | 
-+-+-
 | | 
-+-+-
 | | 

Player O's turn:
2 2

X| | 
-+-+-
 |O| 
-+-+-
 | | 

Player X's turn:
3 1

X| | 
-+-+-
 |O| 
-+-+-
X| | 

Player O's turn:
2 1

X| | 
-+-+-
O|O| 
-+-+-
X| | 

Player X's turn:
1 2

X|X| 
-+-+-
O|O| 
-+-+-
X| | 

Player O's turn:
1 3

X|X|O
-+-+-
O|O| 
-+-+-
X| | 

Player X's turn:
3 2

X|X|O
-+-+-
O|O| 
-+-+-
X|X| 

Player O's turn:
2 3

X|X|O

*/

    
// !!!STRING FORMATTING: Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);





using System;



namespace Tic_Tac_Toe
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("[1] Start game");
            Console.WriteLine("[2] Exit game");
            Console.WriteLine("----------");
            string userInput = Console.ReadLine();
            int userInputConv = Convert.ToInt32(userInput);                                                             // Converting to integer type
            

            switch (userInputConv)
            {
                case 1:
                    start_game();
                    break;
                case 2:
                    exit_game();
                    break;
            }
        }
        
        
        
        
        
        private static void start_game()
        {
            // Declare a single-dimensional array of 5 integers.
            char[,] board = new char[3, 3];
            
            int[] xTurn = new int[2]; 
            int j;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("{0} | {1} | {2}", board[0, 0], board[0, 1], board[0, 2]);
                Console.WriteLine("--+--+--");
                Console.WriteLine("{0} | {1} | {2}", board[1, 0], board[1, 1], board[1, 2]);
                Console.WriteLine("--+--+--");
                Console.WriteLine("{0} | {1} | {2}", board[2, 0], board[2, 1], board[2, 2]);

                playerX(xTurn);

                switch (xTurn[0])
                {
                    // ROW 1
                    case 0 when xTurn[1] == 0:
                        board[0, 0] = 'X';
                        break;
                    case 0 when xTurn[1] == 1:
                        board[0, 1] = 'X';
                        break;
                    case 0 when xTurn[1] == 2:
                        board[0, 2] = 'X';
                        break;
                    // ROW 2
                    case 1 when xTurn[1] == 0:
                        board[1, 0] = 'X';
                        break;
                    case 1 when xTurn[1] == 1:
                        board[1, 1] = 'X';
                        break;
                    case 1 when xTurn[1] == 2:
                        board[1, 2] = 'X';
                        break;
                    // ROW 3
                    case 2 when xTurn[1] == 0:
                        board[2, 0] = 'X';
                        break;
                    case 2 when xTurn[1] == 1:
                        board[2, 1] = 'X';
                        break;
                    case 2 when xTurn[1] == 2:
                        board[2, 2] = 'X';
                        break;
                }
            }
        }

        
        private static void playerX(int[] xTurn)
        {
            Console.Write("\n\n-- Player X's turn:   ");
            for (int j = 0; j < 2; j++) 
                xTurn[j] = Convert.ToInt32(Console.ReadLine());
        }

        
        
        
        private static void exit_game() 
        {
            Environment.Exit(1);
        }
    }
}