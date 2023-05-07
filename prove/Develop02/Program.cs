using System;

class Program
{
    static int IsNumber(string waffles)
    {
        if (!int.TryParse(waffles, out int n))
        {
            Console.WriteLine($"{waffles} is not a number. Please input a number.");
        }
        else{}
        return n;
    }
    static void Main(string[] args)
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            

        }
    }
}