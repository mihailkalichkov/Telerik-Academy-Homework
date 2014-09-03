using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class TomCat : Cat
    {
        private readonly string sex = "male";

        public TomCat(string name, DateTime birthDate) : base(name, birthDate) { }

        public override string Sex
        {
            get { return this.sex; }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Tomcat said miau.");
        }

        public override string ToString()
        {
            return string.Format("I'm tomcat {0}. I'm {1} days old and I'm {2}.", this.Name, this.AgeInDays,this.sex);
        }

        public override void ChaseMice()
        {
            Console.WriteLine("I'm tomcat and I chase mice."); ;
        }
    }
}