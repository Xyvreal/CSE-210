using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Waffle Flipper";
        job1._company = "Tesla Motors";
        job1._startYear = 5469;
        job1._endYear = 6773;

        Job job2 = new Job();
        job2._jobTitle = "Crisis Coordinator";
        job2._company = "Chaos Inc.";
        job2._startYear = 6772;
        job2._endYear = 7865;

        Resume resOne = new Resume();
        resOne._name = "Sammich the Rhetorical";
        resOne._jobs.Add(job1);
        resOne._jobs.Add(job2);

        resOne.Display();
    }
}