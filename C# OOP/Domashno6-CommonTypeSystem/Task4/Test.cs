using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Gosho Goshev");
            Console.WriteLine(person1.ToString());

            Console.WriteLine();

            Person person2 = new Person("Pesho Peshev", 24);
            Console.WriteLine(person2.ToString());
        }
    }
}