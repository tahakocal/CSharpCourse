using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()  //consturactor oldugunu classla ayni isim olmasindan anliyoruz // program csde newledigimiz zaman bu calisiyor
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;  // tempArray dedigimiz olay asagida newlendiginde 101 olan sayi 102 olacak ama 101in sahip oldugu veriler kaybolacak.
                                    // 101IN VERILERI KAYBOLMASIN DIYE TEMPARRAY 101IN VERILERINI TUTUYOR
            items = new T[items.Length+1];   // items.length = ites arrayi 0 elemanli 0+1 olarak item ekliytoruz
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // burada itemleri geri aldik
            }

            items[items.Length - 1] = item; // burada ise itemleri geri ekledik
        }
    }
}
