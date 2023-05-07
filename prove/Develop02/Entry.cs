using System;

public class Entry
//Made up of date - prompt - response and stored as such
//Gets a random prompt from the list of prompts
//Function to get user input and store it into a string
//Function to get the date and store it into a string
{
    private List<string> Prompts;
    public string Prompt;
    public string Response;
    public string Date;
    
    public Entry()
    {
        Prompts = new List<string>{"What was your favorite part of the day?",
                                   "What would you like to do better at tomorrow?",
                                   "How have you served others today?", 
                                   "Do you need to forgive anyone today?",
                                   "Is your current lifestyle making you happy?",
                                   "What are your current priorities and are you following them?"};
        Random rnd = new Random();
        int index = rnd.Next(Prompts.Count);
        Prompt = Prompts[index];
    }

    public string _GetResponse()
    {
        string output = Console.ReadLine();
        return output; 
    }

    public string _GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateToday = theCurrentTime.ToShortDateString();
        return dateToday;
    }
    
}