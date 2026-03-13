using System;
using System.Collections.Generic;
using System.Text;

namespace University_Course_Enrollment_System
{
    abstract class CoreCourse
    {
        protected string title;

        public CoreCourse(string courseTitle)
        {
            title = courseTitle;
        }
        public abstract void EnrollParticipant();
    }
}
