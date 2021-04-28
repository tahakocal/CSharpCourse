using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs = new Kurs();
            kurs.KursAdi = "C#";
            kurs.Egitmen = "Engin Demirog";
            kurs.Izlenme = 9000;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.Izlenme = 10000;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.Izlenme = 11000;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Ahmet";
            kurs4.Izlenme = 12000;

            Kurs[] kurslar = new Kurs[] { kurs, kurs2, kurs3 };

            foreach (var Kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen);
            }

            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int Izlenme { get; set; }
    }
}
    

