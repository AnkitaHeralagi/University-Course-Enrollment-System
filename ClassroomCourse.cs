using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace University_Course_Enrollment_System
{
    internal class ClassroomCourse : CoreCourse
    {
        private string hallNumber;
        private int maxSeats;

        public ClassroomCourse(string title, string room, int capacity) : base(title)
        {
            hallNumber = room;
            maxSeats = capacity;
        }
        public override void EnrollParticipant()
        {
            if (maxSeats > 0)
            {
                Console.WriteLine("\nEnrollment Approved!");
                Console.WriteLine("Course Mode : In-Person");
                Console.WriteLine("Course Name : " + title);
                Console.WriteLine("Room Number : " + hallNumber);
                Console.WriteLine("Capacity    : " + maxSeats);
            }
            else
            {
                Console.WriteLine("Invalid capacity. It must be greater than zero.");
            }
        }
    }
}
