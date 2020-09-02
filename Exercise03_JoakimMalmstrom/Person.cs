using System;
using System.Threading;

namespace Exercise03_JoakimMalmstrom
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;

        // Do not need them, there's no ArgumentExceptions for these
        //private double height;
        //private double weight;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                // If age is less or equals 0
                if (value <= 0)
                {
                    throw new ArgumentException("Age could not be less than 0");
                }
                age = value;
            }
        }
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                // If first name is less than 2 characters
                if (value.Length < 2)
                {
                    throw new ArgumentException("First name cannot be less than 2 characters");
                }
                // if first name is more than 10 characters
                else if (value.Length > 10)
                {
                    throw new ArgumentException("First name cannot be more than 10 characters");
                }
                fName = value;
            }
        }
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                // If last name is less than 3 characters
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 characters");
                }
                // if last name is more than 15 characters
                else if (value.Length > 15)
                {
                    throw new ArgumentException("Last name cannot be more than 15 characters");

                }
                lName = value;
            }
        }
        public double Height { get; set; }
        public double Weight { get; set; }

        // Must have first and last name
        public Person(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }

        // Extensive person with first & last name, age, height and weight
        public Person(string fName, string lName, int age, double height, double weight)
        {
            FName = fName;
            LName = lName;
            Age = age;
            Height = height;
            Weight = weight;
        }
    }
}