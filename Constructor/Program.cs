using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 2;
            customer1.Name = "sad";
            customer1.Surname = "asd";
            customer1.Game = "asdfasdf";

            Customer customer2 = new Customer(2, "Taha", "Kocal", "R6");

            Console.WriteLine(customer2.Name);
        }

    }

    public class Customer
    {

        public Customer()
        {

        }
        public Customer(int id, string name, string surname, string game)
        {
            Id = Id;
            Name = name; // bunu yapmamizin amaci yukariya kadar name geliyo fakat consturctor da parametre ici calistigi icin birbirlerine esitliyorz
            Surname = surname;
            Game = game;
        }




        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Game { get; set; }
    }
}