using System;
using System.Collections.Generic;

namespace ExamJava
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDetails> details = new List<IDetails>()
            {
                new PlasticDetails(),new WoodDetail(),new PaperDetail()
            };
            List<Author> authors = new List<Author>() {
            new Author(),
            new Author(),
            new Author()
            };
            Box box = new Box(details, authors);
            Console.WriteLine(box.GetSumOfDetails());
        }
    }
  }
