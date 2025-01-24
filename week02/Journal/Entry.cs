using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _prompText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date} {_prompText} {_entryText}.");
    }   
}