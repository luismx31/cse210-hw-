using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
       // Console.Write("What is the magic number?");
        //int magicNumber = int.Parse(Console.ReadLine());

         Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine(magicNumber);


        int guess = -1;

         while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }


        
    }
}