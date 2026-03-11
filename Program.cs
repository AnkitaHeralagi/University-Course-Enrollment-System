using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Select Course Type");
        Console.WriteLine("1. Online Course");
        Console.WriteLine("2. In-Person Course");
        Console.WriteLine("3. Lab Course");

        Console.Write("Enter choice: ");
        int option = Convert.ToInt32(Console.ReadLine()!);

        Console.Write("Enter Course Title: ");
        string courseTitle = Console.ReadLine()!;

        CoreCourse? course = null;
        switch (option)
        {
            case 1:
                Console.Write("Enter Video Platform Link: ");
                string link = Console.ReadLine()!;
                course = new DigitalCourse(courseTitle, link);
                break;

            case 2:
                Console.Write("Enter Room Number: ");
                string room = Console.ReadLine()!;

                Console.Write("Enter Capacity: ");
                int cap = Convert.ToInt32(Console.ReadLine()!);

                course = new ClassroomCourse(courseTitle, room, cap);
                break;

            case 3:
                Console.Write("Safety Training Completed? (Yes/No): ");
                string input = Console.ReadLine()!.Trim().ToLower();

                bool safety = input == "yes";

                course = new ExperimentCourse(courseTitle, safety);
                break;

            default:
                Console.WriteLine("Invalid selection.");
                return;
        }
        course?.EnrollParticipant();
    }
}