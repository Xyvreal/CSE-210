using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string fName = Console.ReadLine().Trim();
        Console.WriteLine("What is your last name? ");
        string lName = Console.ReadLine().Trim();

        Console.WriteLine($"Your name is {lName}, {fName} {lName}.");

    } 
}