using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(5, 6);
            SoftwareEngineer softwareEngineer = new SoftwareEngineer(5, 5);

            List<Employee> list = new List<Employee>()
            {
                new SoftwareEngineer(3, 5),
                new Intern(),
                new Employee(5, 6)
            };

            Intern intern = new Intern();
            intern.GetHelp();

           // Employee employee = new Employee(5, 6);
            employee = new SoftwareEngineer(3, 3);
            //(SoftwareEngineer)employee

            //Employee softwareEngineer = new SoftwareEngineer(3,3);
            //softwareEngineer.

            FireEmployee(new Employee(5, 6));
            FireEmployee(new SoftwareEngineer(3, 3));
            FireEmployee(new Intern());

        }

        public static void FireEmployee(Employee employee)
        {
            employee.Fire();
        }
    }
}
