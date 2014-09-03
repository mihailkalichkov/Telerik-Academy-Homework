using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Dog : Animal
    {
        private string sex;

        public Dog(string name, DateTime birthDate, string sex)
            : base(name, birthDate)
        {
            this.sex = sex;
        }

        public override string Sex
        {
            get { return this.sex; }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I'm a dog and I bark."); ;
        }

        public override string ToString()
        {
            return string.Format("I'm dog {0}. I'm {1} days old and I'm {2}.", this.Name, this.AgeInDays, this.Sex);
        }
    }
}