using System;
using System.Linq;

namespace Metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add2(2, 5);

            var result = Add2();

            int number1 = 31;
            int number2 = 20;

            var result2 = Add3(ref number1, number2);

            Console.WriteLine(result2);
            Console.WriteLine(result);


            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));


            Console.WriteLine(Add4(6, 7, 8, 4, 2, 3, 1, 34));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        // void : git sunu yap diyor o yuzden voidi inte ceviriyoruz
        static int Add2(int number1 = 20, int number2 = 10) // bunun anlami add 2 metotunu kullanan bir kisi number1 ve number 2 vermesi gerekiyor bize
        {
            return number1 + number2;
        }
        //OUT VE REF FARKI : REFLE OUT BIRBIRINE BENZER TEK FARKLARI OUT DA BIR SAYI SET ETMEMIZ GEREKMMMMMMIYORRR
        static int Add3(ref int number1, int number2)  // ref sayesinde metotun disindaki veriyidi de etkiliyebiliyor   
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
