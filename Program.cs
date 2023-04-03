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
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start game");
            Console.WriteLine("Exit game");
            Console.WriteLine("----------");
            string userInput = Console.ReadLine();
            int userInputConv = Convert.ToInt32(userInput);                                                             // Converting to integer type


            
            if (userInputConv == 1)
                start_game();
            else if (userInputConv == 2)
                exit_game();

        }
        
        
        
        
        
        private static void start_game() 
        {
           // Declare a single-dimensional array of 5 integers.
           int[,] array = new int[3, 3];
         
            Console.WriteLine("START");
            
            Console.WriteLine("Player X's turn:");
            
            Console.WriteLine(" | | ");
            Console.WriteLine("-+-+-");
            Console.WriteLine(" | | ");
            Console.WriteLine("-+-+-");
            Console.WriteLine(" | | ");
            
            
            
 
            Console.WriteLine("Player 0's turn:");
            
        }
        
        private static void exit_game() 
        {
            Environment.Exit(1);
        }
    }
}