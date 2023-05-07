using System;

class Program
{
    static int IsNumber(string waffles)
    {
        if (!int.TryParse(waffles, out int n)){
            Console.WriteLine($"{waffles} is not a number. Please input a number.");
        }
        else{}
        return n;
    }
    static void Main(string[] args)
    {
        Journal Journal1 = new Journal();
        bool loop = true;
        while (loop)
        {
            int option;
            string choice = "waffle";
            while (!int.TryParse(choice, out option))
            {
                Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
                choice = Console.ReadLine();
            }
            if(option == 1)
            {
                Journal1.NewEntry();
            }
            else if (option == 2)
            {
                Journal1.DisplayJournal();
            }
            else if (option == 3)
            {
                Console.WriteLine("Please input the filename you would like to load from (inclucing .txt)");
                string filenames = Console.ReadLine();
                Journal1.ReadJounal(filenames);
            }
            else if (option == 4)
            {
                Console.WriteLine("Please input the filename you would like to save to (inclucing .txt) ");
                string filenames = Console.ReadLine();
                Journal1.SaveJournal(filenames);
            }
            else if (option == 5)
            {
                Console.WriteLine("Goodby");
                loop = false;
            }
            else{
                Console.WriteLine("Please choose one of the listed options: \n");
            }
        }    
    }
}