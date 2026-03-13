using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace University_Course_Enrollment_System
{
    internal class DigitalCourse : CoreCourse
    {
        private string streamLink;
        public DigitalCourse(string title, string link) : base(title)
        {
            streamLink = link;
        }
        public override void EnrollParticipant()
        {
            if (streamLink.StartsWith("http://") || streamLink.StartsWith("https://"))
            {
                Console.WriteLine("\nEnrollment Approved!");
                Console.WriteLine("Course Mode : Online");
                Console.WriteLine("Course Name : " + title);
                Console.WriteLine("Video Link  : " + streamLink);
            }
            else
            {
                Console.WriteLine("Invalid video platform link. Use http:// or https://");
            }
        }
    }
}
