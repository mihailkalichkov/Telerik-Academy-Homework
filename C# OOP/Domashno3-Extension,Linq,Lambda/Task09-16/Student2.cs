using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academy
{
    public class Student2
    {
        private string firstname;
        private string lastname;
        private string fn;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupnumber;

        public string FirstName
        {
            get
            {
                return this.firstname;
            }
            set
            {
                this.firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastname;
            }
            set
            {
                this.lastname = value;
            }
        }

        public string FN
        {
            get
            {
                return this.fn;
            }
            set
            {
                this.fn = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupnumber;
            }
            set
            {
                this.groupnumber = value;
            }
        }

        public Student2(string FirstName, string LastName, string FN, string Tel, string Email,
        List<int> Marks, int GroupNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FN = FN;
            this.Tel = Tel;
            this.Email = Email;
            this.Marks = Marks;
            this.GroupNumber = GroupNumber;
        }

        public bool ContainMark(int mark)
        {
            return this.Marks.Contains(mark);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Name: {0} {1}", this.FirstName, this.LastName);
            result.AppendLine();
            result.AppendLine("FN: " + this.FN);
            result.AppendLine("Tel: " + this.Tel);
            result.AppendLine("Email: " + this.Email);
            result.AppendLine("Marks: " + string.Join(", ", this.Marks));
            result.Append("Group number: " + this.GroupNumber);

            return result.ToString();
        }

        public string GetMarks()
        {
            return string.Join(", ", this.Marks);
        }
    }
}