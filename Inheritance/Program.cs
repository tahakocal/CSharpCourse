using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person{FirstName= "Taha" ,Id=1,LastName="Kocal"},
                new Customer{FirstName= "SA" ,Id=2,LastName="ASDF"},
                new Student{FirstName= "Guler" ,Id=3,LastName="Kemal"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
        public string Age { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }

}

