namespace Refactoring
{
    using System;

    class HumanPopulation
    {
        public enum Gender { Man, Woman };

        class Human
        {
            public Gender gender { get; set; }
            public string FullName { get; set; }
            public int Age { get; set; }
        }

        public void CreateHuman(int age)
        {
            Human human = new Human();
            human.Age = age;

            if (age % 2 == 0)
            {
                human.FullName = "Pesho Peshev";
                human.gender = Gender.Man;
            }
            else
            {
                human.FullName = "Penka Pencheva";
                human.gender = Gender.Woman;
            }
        }
    }
}