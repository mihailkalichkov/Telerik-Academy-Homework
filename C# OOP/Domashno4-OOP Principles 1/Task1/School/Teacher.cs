using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Teacher : IPerson, IComment
    {
        private string firstName;
        private string lastName;
        private List<Discipline> disciplines = new List<Discipline>();
        private List<string> comments = new List<string>();

        public Teacher(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Incorrect first or last name!");
            }
            this.firstName = firstName.Trim();
            this.lastName = lastName.Trim();
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public void AddDiscipline(params Discipline[] discipline)
        {
            this.disciplines.AddRange(discipline);
        }
        public void RemoveDisciplineAt(int position)
        {
            this.disciplines.RemoveAt(position);
        }

        public override string ToString()
        {
            var teacher = new StringBuilder();
            teacher.AppendLine(this.FirstName + " " + this.LastName + " teaches:");
            foreach (Discipline discipline in disciplines)
            {
                teacher.AppendLine(discipline.Name);
            }
            teacher.Length--;
            return teacher.ToString();
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
                return string.Format("Comments about {0}:\n{1}",
                    this.FirstName + " " + this.LastName, allComments.ToString());
            }
        }
    }
}