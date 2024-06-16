using System;

namespace Inheritance and Method Overriding
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine("Animal makes a sound:");
            animal.MakeSound();

            Console.WriteLine("Dog makes a sound:");
            dog.MakeSound();

            Console.WriteLine("Cat makes a sound:");
            cat.MakeSound();

            Console.ReadLine();
        }
    }
}