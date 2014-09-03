using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1819Namespace;

namespace _18_19.GroupStudents
{
    public class GroupStudents
    {
        //Write a program to return the string with maximum length from an array of strings. Use LINQ.



        static void ExtractLongest()
        {

            var result =
                from str in ArrayofStrings
                orderby str.Length descending
                select str;
         
                Console.WriteLine(result.First());
        
        }

        //Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.

        static void GroupByGroupNameWithLinq()
        {
            var studentsGroupedByGroupNameWithLinq =
                from student in students
                orderby student.GroupName
                select student;


            foreach (var student in studentsGroupedByGroupNameWithLinq)
            {
                Console.WriteLine(student.FullName);
            }
            Console.WriteLine();

        }


        //Rewrite the previous using extension methods.

        static void GroupByGroupNameWithLambda()
        {
            var studentsGroupedByGroupNameWithLambda = students.OrderBy(x => x.GroupName);


            foreach (var student in studentsGroupedByGroupNameWithLambda)
            {
                Console.WriteLine(student.FullName);
            }
            Console.WriteLine();

        }

        static Student[] students;
        static string[] ArrayofStrings;
        static void Main()
        {
            ArrayofStrings =new[] {  "Bob","Unufri", "Byzantine" ,"Georgi"};

            students = new Student[]
            {
                new Student("Pesho Peshev", "C#"),
                new Student("Petranka Petrova", "OOP"),
                new Student("Unifri Zakachliev", "OOP"),
                new Student("Stavri Evlogiev", "HTML"),
                new Student("Valentincho Dimitrov", "OOP"),
                new Student("Mihail Birariev", "HTML")
            };

            ExtractLongest();
            Console.WriteLine();

            GroupByGroupNameWithLinq();

            GroupByGroupNameWithLambda();
        }
    }
}