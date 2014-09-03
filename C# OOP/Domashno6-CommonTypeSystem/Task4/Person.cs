using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Person
    {
        public string Name { get; private set; }
        public int? Age { get; private set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}",
                this.Name, this.Age == null ? "not specified" : this.Age.ToString());
        }
    }
}