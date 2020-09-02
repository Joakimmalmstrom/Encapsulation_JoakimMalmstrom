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
                    Console.WriteLine(p);
                }
            }
            catch (ArgumentException e)
            {
                // If an error occurs, the message will tell you what the cause is
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
