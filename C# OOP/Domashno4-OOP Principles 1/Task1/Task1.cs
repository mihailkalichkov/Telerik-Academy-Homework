using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using School;

namespace Task1
{
    class Task1
    {
        /*We are given a school. In the school there are classes of students.
         * Each class has a set of teachers. Each teacher teaches a set of disciplines.
         * Students have name and unique class number. Classes have unique text identifier. 
         * Teachers have name. Disciplines have name, number of lectures and number of exercises.
         * Both teachers and students are people. Students, classes, teachers and disciplines
         * could have optional comments (free text block).
	     * Your task is to identify the classes (in terms of  OOP) and their attributes and operations,
         * encapsulate their fields, define the class hierarchy and create a class diagram with
         * Visual Studio.*/

        static void Main(string[] args)
        {
            var disciplines = new List<Discipline>();
            disciplines.Add(new Discipline("Math", 23, 34));
            disciplines.Add(new Discipline("Philosophy", 10, 10));
            disciplines.Add(new Discipline("English", 50, 100));
            disciplines.Add(new Discipline("Literature", 40, 45));
            disciplines.Add(new Discipline("SomeDiscipline", 0, 0));
            foreach (Discipline discipline in disciplines)
            {
                Console.WriteLine(discipline.ToString());
            }
            Console.WriteLine();

            disciplines.Last().Lectures = 10;
            disciplines.Last().Exercises = 50;
            foreach (Discipline discipline in disciplines)
            {
                Console.WriteLine(discipline.ToString());
            }
            Console.WriteLine();

            disciplines.Last().AddComment("What a discipline!!!");
            disciplines.Last().AddComment("What an awesome discipline!!!");
            Console.WriteLine(disciplines.Last().Comments);
            Console.WriteLine();
            disciplines.Last().EditComment("What an awesome discipline!!!");
            Console.WriteLine(disciplines.Last().Comments);
            Console.WriteLine();

            Teacher t1 = new Teacher("Ivan", "Petrov");
            Teacher t2 = new Teacher("Petar", "Ivanov");
            t1.AddDiscipline(new Discipline[] { disciplines[0], disciplines[2] });
            t2.AddDiscipline(new Discipline[] { disciplines[1], disciplines[2], disciplines[4] });
            t1.AddComment("Great teacher!");
            t1.AddComment("This teacher sucks.");
            Console.WriteLine(t1.Comments);
            Console.WriteLine();
            Console.WriteLine(t1.ToString());
            Console.WriteLine();
            Console.WriteLine(t2.ToString());
            Console.WriteLine();

            Class class1 = new Class("2B");
            class1.AddTeacher(t1, t2);

            // Uniquenumber is checked for the current class. Allowed the same Uniquenumber in different classes.
            var students = new List<Student>();
            students.Add(new Student("Gosho", "Petrov", 12));
            students.Add(new Student("Aleksandar", "Ivanov", 10));
            //students.Add(new Student("I", "P", 10)); // exception because of UCN (the same with previous)
            students.Add(new Student("Boris", "Neposlushkov", 1));
            class1.AddStudent(students.ToArray());

            class1.AddComment("Greatest class in the world");
            Console.WriteLine(class1.ToString());
            Console.WriteLine();

            foreach (Student student in class1.Students)
            {
                Console.WriteLine("{0} {1}", student.UniqueNumber, student.ToString());
            }

            Class class2 = new Class("A");
            class2.AddStudent(new Student("Grigor", "Dimitrov", 12));
            class2.AddStudent(new Student("Peter", "Pan", 11));
            //class2.AddStudent(new Student("Peter", "Popov", 11)); // exception (same UCN for class2)

            //Class class3 = new Class("A"); // exception - same class identifier with class2
        }
    }
}