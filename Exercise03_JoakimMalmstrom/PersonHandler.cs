using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Exercise03_JoakimMalmstrom
{
    public class PersonHandler
    {
        private List<Person> personList = new List<Person>();

        public PersonHandler()
        {

        }

        // Sets a persons age
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        // Creates a person and adds it to the private list
        public void CreatePerson(string fname, string lname, int age, double height, double weight)
        {
            personList.Add(new Person(fname, lname, age, height, weight));
        }

        // Returns the personlist to a Person Array
        public Person[] PersonList()
        {
            return personList.ToArray();
        }

    }
}