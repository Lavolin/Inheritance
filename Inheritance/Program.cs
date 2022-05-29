using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new SoftwareEngineer(),
                new Intern(),
                new Employee()
            };

            Intern intern = new Intern();
            intern.GetHelp();

            Employee employee = new Employee();
            employee = new SoftwareEngineer();
            //(SoftwareEngineer)employee

            Employee softwareEngineer = new SoftwareEngineer();
            //softwareEngineer.

            FireEmployee(new Employee());
            FireEmployee(new SoftwareEngineer());
            FireEmployee(new Intern());

        }

        public static void FireEmployee(Employee employee)
        {
            employee.Fire();
        }
    }
}
