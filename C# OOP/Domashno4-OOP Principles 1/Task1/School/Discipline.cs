using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Discipline : IComment
    {
        private string name;
        private int lectures;
        private int exercises;
        private List<string> comments = new List<string>();

        public Discipline(string name, int lectures, int exercises)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Incorrect discipline name!");
            }
            if (lectures < 0 || exercises < 0)
            {
                throw new ArgumentException("Lectures and exercises cannot be negative!");
            }
            this.name = name.Trim();
            this.lectures = lectures;
            this.exercises = exercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Lectures
        {
            get
            {
                return this.lectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Lectures cannot be negative!");
                }
                else this.lectures = value;
            }
        }

        public int Exercises
        {
            get
            {
                return this.exercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Exercises cannot be negative!");
                }
                else this.exercises = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: lectures - {1}, exercises - {2}", this.Name, this.Lectures, this.Exercises);
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
                return string.Format("{0} discipline comments:\n{1}", this.Name.ToString(), allComments.ToString());
            }
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
    }
}