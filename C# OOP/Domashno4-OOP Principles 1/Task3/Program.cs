using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Task3
{
    class Task3
    {
        /*Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors
         * and methods. Dogs, frogs and cats are Animals. All animals can produce sound 
         * (specified by the ISound interface). Kittens and tomcats are cats. All animals
         * are described by age, name and sex. Kittens can be only female and tomcats can be
         * only male. Each animal produces a specific sound. Create arrays of different kinds 
         * of animals and calculate the average age of each kind of animal using a static method
         * (you may use LINQ). */

        static void Main(string[] args)
        {
            List<Animal> kittens = new List<Animal>()
            {
                new Kitten("Kity",new DateTime(2014,1,1)),
                new Kitten("Tommy",new DateTime(2013,2,13)),
                new Kitten("Speedy",new DateTime(2014,1,3)),
                new Kitten("Fluffy",new DateTime(2013,8,16)),
                new Kitten("Quicky",new DateTime(2014,2,14)),
            };

            double kittensAverageAge = Animal.AverageAgeInDays(kittens);
            Console.WriteLine("Kittens average age in days: {0}", kittensAverageAge);

            List<Animal> tomcats = new List<Animal>()
            {
                new TomCat("Katy",new DateTime(2010,10,7)),
                new TomCat("Tom",new DateTime(2009,2,13)),
                new TomCat("Mew",new DateTime(2011,1,3)),
                new TomCat("Tommy",new DateTime(2008,8,16)),
                new TomCat("Tim",new DateTime(2012,6,23)),
            };

            double tomcatsAverageAge = Animal.AverageAgeInDays(tomcats);
            Console.WriteLine("Tomcats average age in days: {0}", tomcatsAverageAge);

            List<Animal> frogs = new List<Animal>()
            {
                new Frog("F",new DateTime(2013,9,7),"male"),
                new Frog("FF",new DateTime(2013,9,13),"male"),
                new Frog("FFF",new DateTime(2013,9,3),"female"),
                new Frog("FFFF",new DateTime(2013,9,16),"male"),
                new Frog("FFFFF",new DateTime(2013,9,23),"female"),
            };

            double frogsAverageAge = Animal.AverageAgeInDays(frogs);
            Console.WriteLine("Frogs average age in days: {0}", frogsAverageAge);

            List<Animal> dogs = new List<Animal>()
            {
                new Dog("Sparky",new DateTime(2007,9,7),"male"),
                new Dog("Doggy",new DateTime(2006,9,13),"female"),
                new Dog("Bark",new DateTime(2010,9,3),"female"),
                new Dog("Thunder",new DateTime(2002,9,16),"male"),
                new Dog("Storm",new DateTime(2008,9,23),"male"),
            };

            double dogsAverageAge = Animal.AverageAgeInDays(dogs);
            Console.WriteLine("Dogs average age in days: {0}", dogsAverageAge);

            Console.WriteLine();
            kittens[0].ProduceSound();
            dogs[1].ProduceSound();
            frogs[2].ProduceSound();
            tomcats[3].ProduceSound();
            Console.WriteLine();

            Console.WriteLine(kittens[0].ToString());
            Console.WriteLine(dogs[1].ToString());
            Console.WriteLine(frogs[2].ToString());
            Console.WriteLine(tomcats[3].ToString());
            Console.WriteLine();

            (tomcats[1] as TomCat).ChaseMice();
            (kittens[2] as Kitten).ChaseMice();
        }
    }
}