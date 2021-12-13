using System;
using System.Collections.Generic;

namespace Companies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> buildings = new List<Building>()
            {
                new Building("Forum",4000,600),
                new Building("Spartak",2000,300),
                new Building("VictoriaGaardens",7000,800)
            };
            List<Manager> managers = new List<Manager>()
            {
                new Manager(),new Manager(),new Manager()
            };
            List<Employee> employees = new List<Employee>()
            {
                new Employee(),new Employee(),new Employee()
            };
            Company company = new Company(managers,employees);
            Console.WriteLine(company.CalculateIncome(buildings));
        }
    }
}
