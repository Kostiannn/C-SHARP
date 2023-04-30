using System;

namespace StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string surname = "Okhrimenko";
            string initials = "K.M.";
            string faculty = "Faculty of Information Technology";
            string specialty = "Software Engineering";
            string formOfStudy = "Full-time";
            string group = "ІПЗ 1-3";

            Console.WriteLine("Surname and Initials: " + surname + " " + initials);
            Console.WriteLine("Faculty: " + faculty);
            Console.WriteLine("Specialty: " + specialty);
            Console.WriteLine("Form of Study: " + formOfStudy);
            Console.WriteLine("Group: " + group);

            Console.ReadLine();
        }
    }
}