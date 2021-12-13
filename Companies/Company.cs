using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies
{
    class Company
    {
        private List<Manager> _managment;
        private List<Employee> _employees;

        public Company(List<Manager> managment, List<Employee> employees)
        {
            _managment = managment;
            _employees = employees;
        }
        public double CalculateIncome(List<Building>buildings)
        {
            double sum = 0;
            foreach (var item in buildings)
            {
                sum += item.GetSumOfRentPerMonth();
            }
            foreach (var item in _managment)
            {
                sum -= item.Salary;
            }
            foreach (var item in _employees)
            {
                sum -= item.Salary;
            }
            return sum-(sum*20/100);
        }
    }
}
