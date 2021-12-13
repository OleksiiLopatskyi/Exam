using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies
{
    class Building
    {
        private string _name;
        private double _square;
        private double _pricePerOneMeter;
        public Building(string name,double square,double pricePerOneMeter)
        {
            _name = name;
            _square = square;
            _pricePerOneMeter = pricePerOneMeter;
        }
        public double GetSumOfRentPerMonth()
        {
            return (_pricePerOneMeter * _square) * 30;
        }
    }
}
