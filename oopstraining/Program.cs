using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using oopstraining;

public class Program
{
    static void Main()
    {
        // This was the example for encapsulation + abstraction

        Truck truck = new Truck("BMW");

        truck.Color = "Black";

        truck.Start();

        Console.WriteLine(truck.GetSpeed());

        truck.Accelerate();

        Console.WriteLine(truck.GetSpeed());

        truck.Brake();

        Console.WriteLine(truck.GetSpeed());

        truck.Stop();

        // This was the example for inheritance

        Car car = new Car();

        car.Start();

        car.OpenTrunk();

        Bike bike = new Bike();

        bike.Start();

        bike.Wheelie();

        //Composition
        
        Scooter scooter = new Scooter();

        scooter.StartScooter();

        // Polymorphism

        Animal animal = new Animal();
        animal.Speak();
        Animal dog = new Dog();
        dog.Speak();

        //Interface

        IAnimal animal1 = new Cow();

        animal1.Speak();

        IAnimal animal2 = new Buffalo();

        animal2.Speak();




    }
}
