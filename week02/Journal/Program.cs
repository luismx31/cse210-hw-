using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
   static void Main(string[] args)
   {
       Journal myJournal = new Journal();
       PromptGenerator promptGenerator = new PromptGenerator();

        

          

           
           Console.Write("Please select one of the following choices");

           Console.WriteLine("");
           Console.WriteLine("1. Write");
           Console.WriteLine("2. Display");
           Console.WriteLine("3. Save to file");
           Console.WriteLine("4. Load from file");
           Console.WriteLine("5. Exit");

           string choice = Console.ReadLine();
           do 
           {


                if (choice == "1")
                {
                   AddNewEntry(myJournal, promptGenerator);
                  
                 return;
                }

                else if (choice == "2")
                {
                   myJournal.DisplayAll();
                 
                   return;
                }

                else if (choice == "3")
                {
                   Console.Write("Enter filename to save: ");
                   string saveFile = Console.ReadLine();
                   myJournal.SaveToFile(saveFile);
                   Console.WriteLine("Journal saved successfully!");
        
                   
                }


               else if (choice == "4")
                {
                   Console.Write("Enter filename to load: ");
                   string loadFile = Console.ReadLine();
                   myJournal.LoadFromFile(loadFile);
                   Console.WriteLine("Journal loaded successfully!");
                } 
               
                else if (choice == "5")
                {
                   Console.WriteLine("Exiting the program. Goodbye!");
                 
                }   

                else
                {
                     Console.WriteLine("Invalid choice. Please try again.");
                }            
           } while (choice != "5");
       
    }

   static void AddNewEntry(Journal journal, PromptGenerator promptGenerator)
   {
       string prompt = promptGenerator.GetRandomPrompt();
       Console.WriteLine("\nPrompt: " + prompt);
       Console.Write("Write your response: ");
       string response = Console.ReadLine();

       Entry newEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
       journal.AddEntry(newEntry);

       Console.WriteLine("Entry added successfully!");
   }
}

