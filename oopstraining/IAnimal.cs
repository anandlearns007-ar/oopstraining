using System;
using System.Collections.Generic;
using System.Text;

namespace oopstraining
{
    public interface IAnimal
    {
        void Speak();
    }

    public class Cow : IAnimal {
        public void Speak()
        {
            Console.WriteLine("I am cow and i am sacred");
        }
    }

    public class Buffalo : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("I am Buff and i am heavy");
        }
    }
}
