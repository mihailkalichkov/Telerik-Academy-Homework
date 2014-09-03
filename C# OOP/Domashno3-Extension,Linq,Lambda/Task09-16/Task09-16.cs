using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy;

namespace Task_9_16
{
    class Program
    {
        static void Print(IEnumerable<Student2> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }

        static void Group2StudentsLinq()
        {
            /*Create a class student with properties FirstName, LastName, FN, Tel, 
Email, Marks (a List<int>), GroupNumber. Create a List<Student> with sample students. 
Select only the students that are from group number 2. Use LINQ query. Order the 
students by FirstName.*/


            //LINQ
            var Group2StudentsLinq =
            from student in student2list
            where student.GroupNumber == 2
            orderby student.FirstName
            select student;

            Print(Group2StudentsLinq);
        }



        static void StudentswithEmailinAbv()
        {
            //Extract all students that have email in abv.bg. Use string methods and LINQ.

            var EmailStudents =
            from student in student2list
            where student.Email.EndsWith("abv.bg")
            select student;

            Print(EmailStudents);
        }

        static void StudentwithTelinSofia()
        {
            //Extract all students with phones in Sofia. Use LINQ.

            var TelStudents =
            from student in student2list
            where student.Tel.StartsWith("02")
            select student;

            Print(TelStudents);
        }


        //Select all students that have at least one mark Excellent (6) into a new 
        //anonymous class that has properties – FullName and Marks. Use LINQ.

        static void FindStudentsWithAtLeastOneExcellentMark()
        {
            var studentsWithExcellentMark =
                from student in student2list
                where student.ContainMark(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.GetMarks() };



            foreach (var student in studentsWithExcellentMark)
            {
                Console.WriteLine("{0} -> {1}", student.FullName, student.Marks);
            }
        }

        //Extract all Marks of the students that enrolled in 2006. 
        //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
        static void FindStudentMarksEnrolledIn2006()
        {
            var studentsEnrolledIn2006 =
                from student in student2list
                where student.FN.Substring(4, 2) == "06"
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    FN = student.FN,
                    Marks = student.GetMarks()
                };


            foreach (var student in studentsEnrolledIn2006)
            {
                Console.WriteLine("{0} - FN: {1} -> {2}", student.FullName, student.FN, student.Marks);
            }
            Console.WriteLine();
        }


        static List<Student2> student2list;
        static void Main()
        {
            student2list = new List<Student2>()
			{
			new Student2("Ivan","Petrov", "501706", "0288888", "ivan@gmail.com", new List<int>{6,6,4},1),
            new Student2("Ivan","Georgiev", "501707", "0888878", "ivan@abv.bg", new List<int>{6,3,4},2),
            new Student2("Georgi","Georgiev", "502706", "0288778", "georgi@yahoo.com", new List<int>{4,4,4},2),
            new Student2("Pesho","Petrov", "501700", "0878778", "pesho@abv.bg", new List<int>{3,4,4},3)

			};
            Console.WriteLine("Students with Group 2");
            Console.WriteLine();
            Group2StudentsLinq();

            Console.WriteLine("Students with Email in abv.bg");
            Console.WriteLine();
            StudentswithEmailinAbv();

            Console.WriteLine("Students with Telephone in Sofia");
            Console.WriteLine();
            StudentwithTelinSofia();

            Console.WriteLine("Students with at least one 6 mark");
            FindStudentsWithAtLeastOneExcellentMark();
            Console.WriteLine();

            Console.WriteLine("Students enrolled in 2006");
            FindStudentMarksEnrolledIn2006();
        }
    }
}


