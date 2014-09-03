using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentCommon;

/* http://msdn.microsoft.com/en-us/library/system.object.memberwiseclone.aspx */

namespace Task_1_to_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Petar", "Ivanov", "Petkov", "612345678"),
                new Student("Petar", "Irmanov", "Petrov", "702345677"),
                new Student("Aleksandar", "Mitov", "Kolev", "112345677"),
                new Student("Petar", "Ivanov", "Petkov", "612345677"),
                new Student("Petar", "Ivanov", "Petkov", "512345676"),
            };

            Console.WriteLine(students[0].Equals(students[1]));
            Console.WriteLine(students[0].Equals(new Student("Petar", "Ivanov", "Petrov", "612345678")));
            Console.WriteLine();

            Console.WriteLine(students[0] == students[1]);
            Console.WriteLine(students[0] == new Student("Petar", "Ivanov", "Petrov", "612345678"));
            Console.WriteLine(students[0] != students[1]);
            Console.WriteLine();

            Console.WriteLine(students[3].ToString());
            students[3].University = Universities.UniversityOfArchitectureCivilEngineeringAndGeodesy;
            students[3].Faculty = Faculties.FacultyOfGeodesy;
            students[3].Specialty = Specialties.ProjectManagement;
            Console.WriteLine();
            Console.WriteLine(students[3].ToString());
            Console.WriteLine();

            // deep copy
            Console.WriteLine("Deep copy");
            Student st1 = (students[3].Clone() as Student);
            Console.WriteLine(st1);
            Console.WriteLine();

            // shallow copy
            Console.WriteLine("Shallow copy");
            Student st2 = students[3].ShallowCopy();
            Console.WriteLine(st2);
            Console.WriteLine();

            // use IComparable<Student> 
            students.Sort();
            foreach (Student student in students)
            {
                Console.WriteLine(string.Format("{0} {1} {2} {3}",
                    student.FirstName, student.MiddleName, student.LastName, student.SSN));
            }
        }
    }
}