using System;

namespace oopstraining
{
    public class Truck
    {
        public Truck(string brand)
        {
            Brand = brand;
            Console.WriteLine("Truck object created");
        }
        public string Color { get; set; }

        public string Brand { get; set; }

        private int _speed;

        public int GetSpeed()
        {
            return _speed;
        }

        public void Start()
        {
            Console.WriteLine("Engine started");
        }

        public void Stop()
        {
            Console.WriteLine("Engine stopped");
        }

        public void Accelerate()
        {
            _speed += 10;
            Console.WriteLine($"Speed is now {_speed}");
        }

        public void Brake()
        {
            if (_speed >= 10)
            {
                _speed -= 10;
            }
            else
            {
                _speed = 0;
            }
            Console.WriteLine($"Speed is now {_speed}");
        }
    }
}