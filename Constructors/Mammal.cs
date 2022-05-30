using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Mammal : Animal
    {
        public Mammal(int years) : base()  // base(years)
        {
            this.EatAmount = 66;
            Console.WriteLine("Mammal constructor");
        }

        public int EatAmount { get; set; }

        public void Eat()
        {
            Console.WriteLine("Mammal eating");
        }

        public void MammalEat(int EatAmount)
        {
            Console.WriteLine(EatAmount);
            Console.WriteLine(this.EatAmount);
            Console.WriteLine(base.EatAmount);

            Eat();
            this.Eat();
            base.Eat();
        }
    }
}
