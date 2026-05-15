using System;
using System.Collections.Generic;
using System.Text;

namespace oopstraining
{
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Composition class Engine started");
        }
    }

    public class Scooter
    {
         //private Engine _engine = new Engine();

        private readonly Engine _engine;

        public Scooter()
        {
            _engine = new Engine();
        }

        public void StartScooter()
        {
            Console.WriteLine("I am composition example");
            Console.WriteLine("Scooter is starting");

            _engine.Start();
        }
    }
}
