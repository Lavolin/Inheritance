using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class SoftwareEngineer : Employee
    {
        public Laptop Laptop { get; set; }

        public void Program ()
        {
            Console.WriteLine("Doing nothing all day!!");
        }
    }
}
