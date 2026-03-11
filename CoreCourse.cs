using System;

abstract class CoreCourse
{
    protected string title;

    public CoreCourse(string courseTitle)
    {
        title = courseTitle;
    }
    public abstract void EnrollParticipant();
}