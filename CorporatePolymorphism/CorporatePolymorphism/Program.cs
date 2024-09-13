using System;
using System.Collections.Generic;

namespace CorporatePolymorphism
{
    class Program
    {
        static void Main()
        {
            Employee hrRep = new HR();

            Employee employee1 = new Engineer();

            Engineer? engineer1 = employee1 as Engineer;

            if (engineer1 == null)
                Console.WriteLine("Downcast is failed.");
            Console.WriteLine(); // line break

            Employee employee2 = new Intern();
            Employee employee3 = new Manager();

            // Employee list
            List<Employee> theEmployees = new List<Employee>([hrRep, employee1, employee2, employee3]);

            if (engineer1 != null)
                theEmployees.Insert(2, engineer1);

            foreach (Employee theEmployee in theEmployees)
            {
                Employee.ClockIn();
                theEmployee.Work();
                theEmployee.SubmitDailyReport();

                if (theEmployee is HR)
                    Console.WriteLine("This is a HR.");
                else if (theEmployee is Engineer)
                    Console.WriteLine("This is an Engineer.");
                else if (theEmployee is Intern)
                    Console.WriteLine("This is an Intern.");
                else if (theEmployee is Manager)
                    Console.WriteLine("This is a Manager.");

                Console.WriteLine(); // line break
            }
        }
    }
}