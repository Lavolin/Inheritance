using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual
{
    class Animal
    {
        public Animal()
        {
            Food = 100; 
        }
        public int Food { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("Animal Eating");
            Food -= 25;
        }
    }
}
