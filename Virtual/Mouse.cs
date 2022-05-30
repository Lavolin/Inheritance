using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual
{
    class Mouse : Animal
    {

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Mouse Eating");
            Food -= 1;
        }

        public override string ToString()
        {
            return base.ToString() + "Mishkataaa";
        }
    }
}
