using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public abstract class Animal : ISound
    {
        private string name;
        private DateTime birthDate;

        public Animal(string name, DateTime birthDate)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Enter valid name!");
            }
            if (birthDate > DateTime.Now)
            {
                throw new ArgumentException("Enter valid birthdate!");
            }
            this.name = name;
            this.birthDate = birthDate;
        }

        public string Name { get { return this.name; } }
        public abstract string Sex { get; }
        public double AgeInDays
        {
            get
            {
                return (DateTime.Now - this.birthDate).Days;
            }
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return "I'm " + this.Name;
        }

        public static double AverageAgeInDays(List<Animal> animals)
        {
            return animals.Average(x => x.AgeInDays);
        }
    }
}