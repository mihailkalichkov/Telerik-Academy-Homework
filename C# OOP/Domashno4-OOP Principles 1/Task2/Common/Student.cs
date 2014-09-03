using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Student : Human
    {
        private AssignGrade grade;

        public Student(string firstName, string lastName, AssignGrade grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public AssignGrade Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " - " + grade + " grade";
        }
    }
}