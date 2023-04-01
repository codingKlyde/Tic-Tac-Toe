// STRING FORMATTING: Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);


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
        
        
        
        
        
        static void start_game() 
        {
            Console.WriteLine("START");
        }
        
        static void exit_game() 
        {
            Environment.Exit(1);
        }
    }
}