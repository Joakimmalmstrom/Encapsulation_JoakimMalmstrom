using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03_JoakimMalmstrom
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonHandler personHandler = new PersonHandler();

            try
            {
                // Creates two persons
                personHandler.CreatePerson("Joakim", "Malmström", 29, 184.1, 84.4);
                personHandler.CreatePerson("Sven", "Hellman", 50, 189, 75);

                // Printing the created persons for a list
                foreach (var p in personHandler.PersonList())
                {
                    PrintPersons(p.FName, p.LName, p.Age, p.Height, p.Weight);
                }
            }
            catch (ArgumentException e)
            {
                // If an error occurs, the message will tell you what the cause is
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
        // Created a method for printing the PersonList
        public static void PrintPersons(string fName, string lName, int age, double height, double weight)
        {
            Console.WriteLine($"First Name: {fName}");
            Console.WriteLine($"Last Name: {lName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}\n");
        }
    }
}
