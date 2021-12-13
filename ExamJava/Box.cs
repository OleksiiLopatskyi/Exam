using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamJava
{
    class Box
    {
        private List<IDetails> _details;
        private List<Author> _authors;
        private double _boxPercent { get; } = 20;
        public Box(List<IDetails>details,List<Author>authors)
        {
            _details = details;
            _authors = authors;
        }
        public double GetSumOfDetails()
        {
            double sum = 0;
            foreach (var item in _details)
            {
                sum += item.price;
            }
            sum-=(sum*20/100);
            foreach (var item in _authors)
            {
                item.Sum += sum / 100;
            }
            return sum;
        }
    }
}
