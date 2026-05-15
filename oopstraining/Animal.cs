using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace oopstraining
{
    public class Animal
    {
        public virtual void Speak() 
        {
            Console.WriteLine("Animal Speaks");
        }
    }
    public class Dog : Animal 
    {
        public override void Speak()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
}
