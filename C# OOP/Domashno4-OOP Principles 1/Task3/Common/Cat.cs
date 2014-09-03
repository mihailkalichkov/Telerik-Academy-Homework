using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public abstract class Cat : Animal
    {
        public Cat(string name, DateTime birthDate) : base(name, birthDate) { }

        public abstract void ChaseMice();

        public override void ProduceSound()
        {
            Console.WriteLine("I'm a cat and I say miau."); ;
        }
    }
}