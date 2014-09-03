using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academy
{
    public class Student
    {
        private string name = null;
        private string family = null;
        private int age;

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Family
        {
            get
            {
                return this.family;
            }
            set
            {
                this.family = value;
            }
        }

        public Student(string name, string family, int age)
        {
            this.name = name;
            this.family = family;
            this.age = age;
        }

        public static IEnumerable<Student> NameBeforeFamily(Student[] students)
        {
            var selectedStudents =
                from student in students
                where student.Name.CompareTo(student.Family) < 0
                select student;

            return selectedStudents;
        }

        public static IEnumerable<Student> AgeBetween(Student[] students, int lowAge, int upAge)
        {
            var selectedStudents =
                from student in students
                where student.Age >= lowAge && student.Age <= upAge
                select student;

            return selectedStudents;
        }

        public static Student[] SortDescending(Student[] students)
        {
            var sortedStudents =
                from student in students
                orderby student.Name descending, student.Family descending
                select student;

            return sortedStudents.ToArray<Student>();
        }


    }
}