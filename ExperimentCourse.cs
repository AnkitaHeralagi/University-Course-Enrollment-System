using System;
using static System.Net.WebRequestMethods;

class ExperimentCourse : CoreCourse
{
    private bool safetyDone;
    public ExperimentCourse(string title, bool safetyStatus) : base(title)
    {
        safetyDone = safetyStatus;
    }
    public override void EnrollParticipant()
    {
        if (safetyDone)
        {
            Console.WriteLine("\nEnrollment Approved!");
            Console.WriteLine("Course Mode : Laboratory");
            Console.WriteLine("Course Name : " + title);
            Console.WriteLine("Safety Training : Completed");
        }
        else
        {
            Console.WriteLine("Enrollment denied. Safety training required.");
        }
    }
}