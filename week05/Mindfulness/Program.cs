using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please select an activity to begin:");

        // Display Menu
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflecting Activity");
        Console.WriteLine("4. Exit");

        int choice = int.Parse(Console.ReadLine());

        Activity activity = null;

        switch (choice)
        {
            case 1:
                activity = new BreathingActivity();
                break;
            case 2:
                activity = new ListingActivity();
                break;
            case 3:
                activity = new ReflectingActivity();
                break;
            case 4:
                return;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                return;
        }

        activity.Run();
    }
}