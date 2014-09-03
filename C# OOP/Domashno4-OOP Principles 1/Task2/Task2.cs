using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Task2
{
    class Task2
    {
        /*Define abstract class Human with first name and last name. 
         * Define new class Student which is derived from Human and has new field – grade. 
         * Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
         * and method MoneyPerHour() that returns money earned by hour by the worker. Define the 
         * proper constructors and properties for this hierarchy. Initialize a list of 10 students 
         * and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
         * Initialize a list of 10 workers and sort them by money per hour in descending order. 
         * Merge the lists and sort them by first name and last name.*/

        static void Main(string[] args)
        {
            // assign students
            IList<Student> students = new List<Student>()
            {
                new Student("Ivan", "Petrov", AssignGrade.First),
                new Student("Ivan", "Dimitrov", AssignGrade.Fifth),
                new Student("Petar", "Ivanov", AssignGrade.First),
                new Student("Niki", "Marinov", AssignGrade.Second),
                new Student("Marin", "Asenov", AssignGrade.Fifth),
                new Student("Qvor", "Kolev", AssignGrade.Third),
                new Student("Kalin", "Stoqnov", AssignGrade.Second),
                new Student("Kiril", "Dimitrov", AssignGrade.Fourth),
                new Student("Dimitar", "Cekov", AssignGrade.Third),
                new Student("Niki", "Veselinov", AssignGrade.Fourth),
            };

            // sort students by grade
            var studentsByGrade = students.OrderBy(x => x.Grade);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Students ordered by grade:");
            Console.ResetColor();
            foreach (Student student in studentsByGrade)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();

            // sort students by first name and last name
            var studentsByNames =
                from student in students
                orderby student.FirstName, student.LastName
                select student;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Students ordered by first name and last name:");
            Console.ResetColor();
            foreach (Student student in studentsByNames)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();

            // assign workers, added w at the end of Last Name so we can see the difference when merged with students
            IList<Worker> workers = new List<Worker>()
            {
                new Worker("Ivan", "Petrovw", 120, 8),
                new Worker("Ivan", "Dimitrovw", 200, 6),
                new Worker("Petar", "Ivanovw", 305, 7),
                new Worker("Niki", "Marinovw", 1000, 8),
                new Worker("Marin", "Asenovw", 550, 5),
                new Worker("Qvor", "Kolevw", 400, 8),
                new Worker("Kalin", "Stoqnovw", 320, 6),
                new Worker("Kiril", "Dimitrovw", 1200, 8),
                new Worker("Dimitar", "Cekovw", 720, 7),
                new Worker("Niki", "Veselinovw", 605, 7),
            };

            // sort workers by money per hour in descending order
            var workersByMoneyPerHour = workers.OrderByDescending(x => x.MoneyPerHour);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Workers ordered by money per hour in descending order:");
            Console.ResetColor();
            foreach (Worker worker in workersByMoneyPerHour)
            {
                Console.WriteLine(worker.ToString());
            }
            Console.WriteLine();

            // sort workers by first name and last name descending
            var workersByNames =
                from worker in workers
                orderby worker.FirstName descending, worker.LastName descending
                select worker;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Workers ordered by first name and last name:");
            Console.ResetColor();
            foreach (Worker worker in workersByNames)
            {
                Console.WriteLine(worker.ToString());
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Humans ordered by first name and last name:");
            Console.ResetColor();

            var mergedlists = workers.Concat<Human>(students).ToList();
            mergedlists = mergedlists.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();

            foreach (var person in mergedlists)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }
    }
}