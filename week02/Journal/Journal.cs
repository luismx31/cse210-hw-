using System;
using System.Globalization;
using System.IO;
using Microsoft.VisualBasic;

public class Journal
{
   private List<Entry> _entries = new List<Entry>();
    

    //new entry
   public void AddEntry(Entry newEntry)
   {
       _entries.Add(newEntry);
   }
   
    //display entries
   public void DisplayAll()
   {
       if (_entries.Count == 0)
       {
           Console.WriteLine("No journal entries to display.");
           return;
       }

       foreach (Entry entry in _entries)
       {
           entry.Display();
       }
   }

   public void SaveToFile(string file)
   {
       using (StreamWriter writer = new StreamWriter(file))
       {
           foreach (Entry entry in _entries)
           {
               writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
           }
       }
   }

   public void LoadFromFile(string file)
   {
       if (File.Exists(file))
       {
           _entries.Clear();
           string[] lines = File.ReadAllLines(file);
           foreach (var line in lines)
           {
               string[] parts = line.Split('|');
               if (parts.Length == 3)
               {
                   _entries.Add(new Entry(parts[0], parts[1], parts[2]));
               }
           }
       }
       else
       {
           Console.WriteLine("File not found.");
       }
   }
}
