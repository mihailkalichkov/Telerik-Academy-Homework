using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Frog : Animal
    {
        private string sex;

        public Frog(string name, DateTime birthDate, string sex)
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
            Console.WriteLine("I'm a frog and I croak."); ;
        }

        public override string ToString()
        {
            return string.Format("I'm frog {0}. I'm {1} days old and I'm {2}.", this.Name, this.AgeInDays, this.Sex);
        }
    }
}