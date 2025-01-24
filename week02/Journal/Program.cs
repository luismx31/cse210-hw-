using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please selct one of the following chioces:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");

        Console.Write("What would you like to do?");
        string option = Console.ReadLine();
        
        Journal theJoural = new Journal();
        Entry anEntry = new Entry();

      
    }
}