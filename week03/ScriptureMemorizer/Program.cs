using System;

class Program
{
   static void Main(string[] Arg)
   {
       Reference scriptureReference = new Reference("John", 3, 16);
       string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
       Scripture scripture = new Scripture(scriptureReference, scriptureText);

       Console.Clear();
       Console.WriteLine("Memorize the following scripture:");
       Console.WriteLine(scripture.GetDisplayText());
       Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

       while (!scripture.IsCompletelyHidden())
       {
           Console.Write("\nPress Enter to hide words...");
           string input = Console.ReadLine();
           if (input.ToLower() == "quit") break;

           scripture.HideRandomWords(2);
           Console.Clear();
           Console.WriteLine(scripture.GetDisplayText());
       }

       Console.WriteLine("\nScripture completely hidden! Well done.");
   }
}