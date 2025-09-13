using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first job
        Job job1 = new Job();
        job1._jobTitle = "photography";
        job1._company = "JJ creatitive studio";
        job1._startYear = 2025;
        job1._endYear = 2025;

        // Create second job
        Job job2 = new Job();
        job2._jobTitle = "checker";
        job2._company = "Infiouest international construction";
        job2._startYear = 2025;
        job2._endYear = 2026;

        // Create resume and add jobs
        Resume myResume = new Resume();
        myResume._name = "Otu Maduabuchi";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display resume
        myResume.Display();
    }
}
