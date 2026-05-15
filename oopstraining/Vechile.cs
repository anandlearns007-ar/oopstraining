using System;
using System.Collections.Generic;
using System.Text;

namespace oopstraining
{
    public class Vehicle
    {
        public Vehicle() { }

        public void Start()
        {
            Console.WriteLine("Engine started");    
        }
    }

    public class Car : Vehicle
    {
        public void OpenTrunk() {
            Console.WriteLine("Trunk is open");
        }
    }

    public class Bike : Vehicle
    {
        public void Wheelie()
        {
            Console.WriteLine("Bike is in the air");
        }
    }

}
