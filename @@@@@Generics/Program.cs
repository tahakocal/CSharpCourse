using System;
using System.Collections.Generic;

namespace _____Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Manisa");

            MyList<string> sehirler2 = new MyList<string>();   
            sehirler2.Add("Ankara");


        }
    }

    class MyList<T>  // Typedan geliyor T
    {
        public void Add(T items)
        {

        }

    }


}
