using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int SquaredNumber = SquareNumber(number);
        DisplayResult(name,SquaredNumber);

    }

        //Function1,display welcome

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");

        }
        //Finction2,get user name

        static string PromptUserName()
        {
            Console.Write("Please enter your name:");            
            string name = Console.ReadLine();
            return name;

        }

        //Function3, get favorite number

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number:");
            int number =  int.Parse(Console.ReadLine());
            return number;
        }
        //Function4, get the square number

        static int SquareNumber(int number)
        {
        int square = number * number;
        return square;
        }

         static void DisplayResult(string name, int square)
         {
            Console.WriteLine($"Brother {name}, the square of your number is {square}");

         }
  
}