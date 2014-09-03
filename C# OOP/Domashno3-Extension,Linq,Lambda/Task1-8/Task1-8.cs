using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Extensions;
using Academy;

namespace OOP___HW3
{
    class HW3
    {
        static void Main(string[] args)
        {
            /*Implement an extension method Substring(int index, int length) for the class StringBuilder
             * that returns new StringBuilder and has the same functionality as Substring in the class
             * String. */

            var text = new StringBuilder("Implement an extension method");
            Console.WriteLine(text.Substring(0, 9));
            Console.WriteLine(text.Substring(13, 16));
            Console.WriteLine(text.Substring(10, 12));
            Console.WriteLine();

            /*Implement a set of extension methods for IEnumerable<T> that implement the following group
             * functions: sum, product, min, max, average. */
            var arr1 = new double[] { 2.3, 1.1, 5, 8.8 };
            var arr2 = new List<int>() { 2, 2, 1, 4, 5 };

            Console.WriteLine("First array sum: {0}", arr1.Sum());
            Console.WriteLine("Second array sum: {0}", arr2.Sum());

            Console.WriteLine("First array min: {0}", arr1.Min());
            Console.WriteLine("Second array min: {0}", arr2.Min());

            Console.WriteLine("First array max: {0}", arr1.Max());
            Console.WriteLine("Second array max: {0}", arr2.Max());

            Console.WriteLine("First array average: {0}", arr1.Average());
            Console.WriteLine("Second array average: {0}", arr2.Average());

            Console.WriteLine("First array product: {0}", arr1.Product());
            Console.WriteLine("Second array product: {0}", arr2.Product());
            Console.WriteLine();

            /*Write a method that from a given array of students finds all students
             * whose first name is before its last name alphabetically. Use LINQ query operators.*/
            Student[] studentsList = new Student[]
            {
                new Student("Ivan","Petrov",18),
                new Student("Qvor","Ivanov",33),
                new Student("Petyr","Andonov",24),
                new Student("Atanas","Minkov",21),
                new Student("Plamen","Borisov",17),
                new Student("Plamen","Stavrev",64),
            };

            var selected = Student.NameBeforeFamily(studentsList);
            foreach (Student student in selected)
            {
                Console.WriteLine(student.Name + " " + student.Family);
            }
            Console.WriteLine();

            /*Write a LINQ query that finds the first name and last name of all students with age
             * between 18 and 24.*/

            selected = Student.AgeBetween(studentsList, 18, 24);
            foreach (Student student in selected)
            {
                Console.WriteLine(student.Name + " " + student.Family);
            }
            Console.WriteLine();

            /*Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students
         * by first name and last name in descending order. Rewrite the same with LINQ.*/

            // lambda expression
            Student[] sortedLambda = studentsList.OrderByDescending(name => name.Name).
                ThenByDescending(name => name.Family).ToArray<Student>();
            foreach (Student student in sortedLambda)
            {
                Console.WriteLine(student.Name + " " + student.Family);
            }
            Console.WriteLine();

            // LINQ
            studentsList = Student.SortDescending(studentsList);
            foreach (Student student in studentsList)
            {
                Console.WriteLine(student.Name + " " + student.Family);
            }
            Console.WriteLine();

            /*Write a program that prints from given array of integers all numbers that are
             * divisible by 7 and 3. Use the built-in extension methods and lambda expressions.
             * Rewrite the same with LINQ. */

            int[] ints = new int[] { 3, 18, 24, 12, 7, 88, 102, 13, 44, 21, 42, 68 };

            // lambda expression
            var divisible = ints.Where(x => x % 3 == 0 && x % 7 == 0);
            foreach (var number in divisible)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();

            // LINQ
            divisible =
                from num in ints
                where num % 3 == 0 && num % 7 == 0
                select num;

            foreach (var number in divisible)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            Console.WriteLine();

            /*Using delegates write a class Timer that can execute
             * certain method at each t seconds.*/

            MyTimer.Start(1);
            MyTimer.Start2(2);
			

        }
    }
}