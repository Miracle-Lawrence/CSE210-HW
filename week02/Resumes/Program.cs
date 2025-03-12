using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Creating the first object "Job1" for the Job class
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "SmartSprout";
        job1._startYear = 2025;
        job1._endYear = 2056;
        

        //Creating the second object "Job 2" for the Job class
        Job job2 = new Job();
        job2._jobTitle = "Marketer";
        job2._company = "Okubomarine";
        job2._startYear = 2012;
        job2._endYear = 2020;
        


        // Creating a new object for the Resume class 
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();  

    }
}