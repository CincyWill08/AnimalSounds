using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Elephant elephant = new Elephant();
            Monkey monkey = new Monkey();
            Cat cat = new Cat();
            Cow cow = new Cow();
            Chicken chicken = new Chicken();
            Pig pig = new Pig();
            Lion lion = new Lion();
            Hyena hyena = new Hyena();
            Horse horse = new Horse();
            ISounds[] animals = {dog, elephant, monkey, cat, cow, chicken, pig, lion, hyena, horse};

            foreach(ISounds animal in animals)
            {
                string animalName = animal.GetName();
                string animalSound = animal.GetSound();
                string message = $"A(n) {animalName} says {animalSound}.";
                Console.WriteLine(message);
            }
            Console.ReadKey();
        }
    }
}
