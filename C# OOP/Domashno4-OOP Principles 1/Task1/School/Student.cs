using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : IPerson, IComment
    {
        private string firstName;
        private string lastName;
        private int uniqueNumber;
        private List<string> comments = new List<string>();

        public Student(string firstName, string lastName, int uniqueNumber)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Invalid First or Last name");
            }
            this.firstName = firstName;
            this.lastName = lastName;
            this.uniqueNumber = uniqueNumber;
        }

        public string FirstName
        {
            get { return this.firstName; }
        }
        public string LastName
        {
            get { return this.lastName; }
        }
        public int UniqueNumber
        {
            get { return this.uniqueNumber; }
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
        public void AddComment(string comment)
        {
            this.comments.Add(comment);
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

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
