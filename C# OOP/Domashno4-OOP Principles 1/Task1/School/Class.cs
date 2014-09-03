using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Class : IComment
    {
        private List<string> comments = new List<string>();
        private string identifier;
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        private List<int> enteredUcn = new List<int>();

        public Class(string identifier)
        {
            if (string.IsNullOrWhiteSpace(identifier))
            {
                throw new ArgumentException("Incorrect class unique text identifier!");
            }
            ClassIdentifier.Check(identifier);
            this.identifier = identifier.Trim();
        }

        public string Identifier
        {
            get { return this.identifier; }
        }

        public List<Student> Students
        {
            get { return this.students.ToList(); }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers.ToList(); }
        }

        public void AddStudent(params Student[] students)
        {
            foreach (Student student in students)
            {
                CheckUCN(student.UniqueNumber);
            }
            this.students.AddRange(students);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void AddTeacher(params Teacher[] teacher)
        {
            this.teachers.AddRange(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }

        public void EditComment(string comment)
        {
            int index = this.comments.IndexOf(comment);
            Console.WriteLine("Edit: {0}", comments[index]);
            Console.Write("Enter edited comment: ");
            string edited = Console.ReadLine();
            this.comments.RemoveAt(index);
            this.comments.Insert(index, edited);
        }

        public string Comments
        {
            get
            {
                var allComments = new StringBuilder();
                foreach (var comment in comments)
                {
                    allComments.AppendLine(comment);
                }
                allComments.Length--;
                return string.Format("Comments about {0} class:\n{1}",
                    this.identifier, allComments.ToString());
            }
        }

        private void CheckUCN(int ucn)
        {
            for (int i = 0; i < enteredUcn.Count; i++)
            {
                if (ucn == enteredUcn[i])
                {
                    throw new ArgumentException(string.Format
                        ("UCN - {0} in \"{1}\" class is already entered!", ucn, this.Identifier));
                }
            }
            enteredUcn.Add(ucn);
        }

        public override string ToString()
        {
            var printClass = new StringBuilder();
            printClass.AppendFormat("{0} class:", this.Identifier);
            printClass.AppendLine();
            printClass.AppendLine("Teachers:");
            var teacherList = this.Teachers;
            foreach (Teacher teacher in teacherList)
            {
                printClass.AppendLine(teacher.FirstName + " " + teacher.LastName);
            }
            printClass.AppendLine("Students:");
            var studentsList = this.Students;
            foreach (Student student in studentsList)
            {
                printClass.AppendLine(student.FirstName + " " + student.LastName);
            }

            return printClass.ToString();
        }
    }
}