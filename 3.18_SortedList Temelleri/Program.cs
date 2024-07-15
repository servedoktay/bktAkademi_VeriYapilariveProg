using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._18_SortedList_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sortedlist temelleri

            //TANIMLAMA
            var list = new SortedList()
            {
                //EKLEME
                { 1,"Bir"},
                {2,"İki" },
                {3,"Üc" },
                {8,"Sekiz" },
                {5,"Beş" },
                {6,"Altı" }

            }; //sıralı dır
            //list.Add(1,"Bir");
            //list.Add(2, "İki");

            list.Add(4, "Dört");
            //DOLASŞMA
            foreach (DictionaryEntry item in list)
            {
                //Console.WriteLine(item.Value);
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Listedeki eleman sayisi..:{0}", list.Count);
            Console.WriteLine("Listenin kapasitesi....:{0}",list.Capacity);
            list.TrimToSize(); //kesmek elaman  sayısına gore
            Console.WriteLine("listennin kapasitesi   :{0}",list.Capacity);
            Console.WriteLine();
            //özel bir elemana erisim

            //key
            Console.WriteLine(list[4]); //4 index degildir keydir
            Console.WriteLine();
            //index
            Console.WriteLine(list.GetByIndex(0)); //belirtilen indexin valusunu getirir

            //get key
            Console.WriteLine(list.GetKey(0)); //0.indexdeki keyi getir

            //liste sonundaki elemanın degeri
            Console.WriteLine(list.GetByIndex(list.Count-1));
            //en son indexi getir

            var anahtarlar = list.Keys;
            Console.WriteLine("\nANAHTARLAR");
            foreach(var key in anahtarlar)
            {
                Console.WriteLine(key);
            }
            var degerler = list.Values;
            Console.WriteLine();
            Console.WriteLine("DEGERLER");
            foreach(var value in degerler)
            {
                Console.WriteLine(value);
            }

            //herhangi bir keyin olup olmadıgını kontrol etme
            //guncelleme
            if (list.ContainsKey(1))
            {
                list[1] = "Oneeee";
            }
            Console.WriteLine();
            foreach (DictionaryEntry item in list)
            {
                //Console.WriteLine(item.Value);
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();
            list.Remove(1);
            foreach (DictionaryEntry item in list)
            {
                //Console.WriteLine(item.Value);
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
