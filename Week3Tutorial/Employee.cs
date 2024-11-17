using System;
namespace Week3Tutorial
{
    public abstract class Employee
    {
        // private set le direct name lina didaina eg employee.name= bhanera assign garna mildaina  
        public string Name { get; private set; }
        public string Position { get; set; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        // abstract vs virtual =  
        public abstract int CalculateSalary();
        public virtual void DisplayEmployeeDetails()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Position: {Position}");
        }
    }
}


