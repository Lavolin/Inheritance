using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(3);

            Mammal mammal = new Mammal(4);
            mammal.MammalEat(5);
        }
    }
}
