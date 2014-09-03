using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentCommon
{
    public class Student : ICloneable, IComparable<Student>
    {
        private string ssn;

        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string SSN  // social security number - 9 digits
        {
            get
            {
                return this.ssn;
            }
            private set
            {
                if (value.Length != 9)
                {
                    throw new ArgumentException
                        (string.Format("Incorrect social security number of student {0}!", this.FirstName + " " + this.LastName));
                }
                for (int i = 0; i < 9; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        throw new ArgumentException
                            (string.Format("Incorrect social security number of student {0}!", this.FirstName + " " + this.LastName));
                    }
                }
                this.ssn = value;
            }
        }
        public string PermanentAddress { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public Nullable<Specialties> Specialty { get; set; }
        public Nullable<Universities> University { get; set; }
        public Nullable<Faculties> Faculty { get; set; }

        public Student() { }

        public Student(string firstName, string middleName, string lastName, string ssn)
        {
            this.FirstName = firstName.Trim();
            this.MiddleName = middleName.Trim();
            this.LastName = lastName.Trim();
            this.SSN = ssn.Trim();
        }

        public override bool Equals(object obj)
        {
            // If the cast is invalid, the result will be null
            Student student = obj as Student;

            // Check if we have valid not null Student object
            if (student == null)
            {
                return false;
            }

            // Compare the reference type member field
            if (!object.Equals(this.SSN, student.SSN))
            {
                return false;
            }

            return true;
        }
        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !Student.Equals(student1, student2);
        }
        public override string ToString()
        {
            var student = new StringBuilder();
            student.AppendLine(this.FirstName + " " + this.MiddleName + " " + this.LastName);
            student.AppendFormat("Social security number: {0}", this.SSN);
            student.AppendLine();
            student.AppendFormat("University: {0}\nFaculty: {1}\nSpecialty: {2}",
                this.University, this.Faculty, this.Specialty);

            return student.ToString();
        }
        public object Clone()
        {
            var obj = new Student();
            obj.FirstName = (string)this.FirstName.Clone();
            obj.MiddleName = (string)this.MiddleName.Clone();
            obj.LastName = (string)this.LastName.Clone();
            obj.SSN = (string)this.SSN.Clone();
            if (this.PermanentAddress != null)
            {
                obj.PermanentAddress = (string)this.PermanentAddress.Clone();
            }
            if (this.Mobile != null)
            {
                obj.Mobile = (string)this.Mobile.Clone();
            }
            if (this.Email != null)
            {
                obj.Email = (string)this.Email.Clone();
            }
            obj.Course = this.Course;
            obj.Specialty = this.Specialty;
            obj.Faculty = this.Faculty;
            obj.University = this.University;

            return obj;
        }
        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            else if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            else
            {
                return this.SSN.CompareTo(other.SSN);
            }
        }

        public Student ShallowCopy()
        {
            return (this.MemberwiseClone() as Student);
        }
    }
}
