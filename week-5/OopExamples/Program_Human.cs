using System;

namespace OopExamples
{
    class Program_Human
    {
        static void Main_Human(string[] args)
        {
            var besir = new Human()
            {
                Name = "Beşir",
                Surname = "Gündüz",
                Age = 23
            };

            var abdullah = new Human()
            {
                Name = "Abdullah"

            };
            abdullah.Age = -3;

            var berke = new Gamer()
            {
                Name = "Berke",
                Game = "PUB",
                Level = 12,
                MouseUsingLevel = 90,
            };

            Console.WriteLine(besir.Name + " - " + abdullah.Name);

        }
    }

    abstract class Creature
    {
        public abstract void Birn();
        public abstract void Die();
    }

    class Tree : Creature
    {
        public override void Birn()
        {
            throw new NotImplementedException();
        }

        public override void Die()
        {
            throw new NotImplementedException();
        }
    }

    class Dog : Creature, IWalkabla
    {
        public string Name { get; set; }
        public override void Birn()
        {
            throw new NotImplementedException();
        }

        public override void Die()
        {
            throw new NotImplementedException();
        }
    }

    class Human : Creature, IThinkable, IWalkabla
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Surname { get; set; }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Hop, insan yaşı sıfırdan küçük olamaz!");
                }

                age = value;
            }
        }

        public override void Birn()
        {
            throw new NotImplementedException();
        }

        public override void Die()
        {
            throw new NotImplementedException();
        }
    }

    interface IThinkable
    {

    }

    interface IWalkabla
    {

    }


    interface ICanUseMouse
    {
        int MouseUsingLevel { get; set; }
    }

    interface IPlayable { }

    class Gamer : Human, ICanUseMouse
    {
        public string Game { get; set; }
        public int Level { get; set; }
        public int MouseUsingLevel { get; set; }
    }

}
