using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concepts_review.ObjectOriented
{
    public class Human
    {
        public string? FirstName { get; set; }
        public int Age { get; set; }
        private double Salary { get; set; }
        private string? _JobTitle { get; set; }
        public string JobTitle
        {
            get
            {
                return _JobTitle ?? "Unknown";
            }
            set
            {
                if(Salary > 0)
                {
                    _JobTitle = value;
                }
            }
        }

        public Human(string? firstName, int age)
        {
            FirstName = firstName;
            Age = age;
        }

        public Human()
        {
        }
        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {FirstName} and I am {Age} years old");
        }
        ~Human()
        {
            Console.WriteLine("Human destroyed");
        }

    }
}
