namespace HighQualityMethods
{
    using System;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public PersonalInformation PersonalInfo { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            bool isOlder = false;
            DateTime firstStudentBirthDate = this.PersonalInfo.BirthDate;
            DateTime secondStudentBirthDate = otherStudent.PersonalInfo.BirthDate;

            if (DateTime.Compare(firstStudentBirthDate, secondStudentBirthDate) < 0)
            {
                isOlder = true;
            }

            return isOlder;
        }
    }

    public class PersonalInformation
    {
        public PersonalInformation(string birthdate, string birthplace = null)
        {
            DateTime outParamBirthDate;

            if (!DateTime.TryParse(birthdate, out outParamBirthDate))
            {
                throw new FormatException("Incorrect Date format! Correct format is DD.MM.YYYY.");
            }

            this.BirthDate = outParamBirthDate;
            this.BirthPlace = birthplace;
        }

        public DateTime BirthDate { get; set; }

        public string BirthPlace { get; set; }
    }
}
