using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfacesIntro();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new ICustomerDal.OracleCustomerDal());


            Console.ReadLine();
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Taha",
                LastName = "Kocal",
                Address = "Istanbul"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Kemal",
                LastName = "Guler",
                Departmant = "Pilot"
            };

            personManager.Add(student);
            personManager.Add(customer);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }

        
    }

}
