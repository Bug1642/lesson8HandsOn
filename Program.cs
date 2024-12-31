using System;
namespace Excerise
{
    public interface Mammal
    {
        void Speak();
        void run();
    }
    public interface Animal
    {
        void eat();
    }
    public class Dog : Mammal, Animal
    {
        public void Speak()
        {
            Console.WriteLine("Bark!");
        }
        public void run() 
        { 
            Console.WriteLine("Dogs can run at a top speed of 45 mph!");
        }
        public void eat()
        {
            Console.WriteLine("Dogs eat bones.");
        }
    }
    public class Cat : Mammal, Animal
    {
        public void Speak()
        {
            Console.WriteLine("Meow!");
        }
        public void run()
        {
            Console.WriteLine("Cats can run at a top speed of 30 mph!");
        }
        public void eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }
    public class Cow : Mammal , Animal
    {
        public void Speak()
        {
            Console.WriteLine("Moo!");
        }
        public void run()
        {
            Console.WriteLine("Cows can run at a top speed of 25 mph!");
        }
        public void eat()
        {
            Console.WriteLine("Cows eat grass.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Speak();
            dog.run();
            dog.eat();
            Cat cat = new Cat();
            cat.Speak();
            cat.run();
            cat.eat();
            Cow cow = new Cow();
            cow.Speak();
            cow.run();
            cow.eat();
        }
    }
}
