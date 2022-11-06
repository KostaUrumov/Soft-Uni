using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Animal animal = new Animal();
            animal.Eat();

            Puppy puppy = new Puppy();

            puppy.Weep();  


        }
    }
}

