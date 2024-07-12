using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._15_HashTable_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hastable
            //tanimlama
            var sehirler = new Hashtable();

            //ekleme yapma
            sehirler.Add(6, "Ankara");
            sehirler.Add(26, "Eskişehir");
            sehirler.Add(34,"İstanbul");
            sehirler.Add(1, "Adana");
            //bellek uzerdinde sıralı gelıyor

            //dolaşma
            foreach (DictionaryEntry sehir in sehirler)
            {
                //f12 ile bak key ve value gorduk
                Console.WriteLine($"{sehir.Key,-5}-" +
                    $"{sehir.Value,5}-"); //sehir bir dictinipry entrydir
            }
            //sadece anahtarları alma
            Console.WriteLine("Keyler");
            var anahtarlar = sehirler.Keys;
            foreach(var item in anahtarlar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Degerler");
            ICollection degerler = sehirler.Values;
            //metotlarınına bakmak icin f12
            foreach (var item in degerler) 
            {
                Console.WriteLine(item);
            }

            //elemana erişmek
            Console.WriteLine(sehirler[26]); //koselı parantez key
                                             //ekran goruntusu eskişehir olur 26 keyini girdik diye

            //eleman kaldırmak(silmek)
            sehirler.Remove(1);
            foreach (DictionaryEntry sehir in sehirler)
            {
                //f12 ile bak key ve value gorduk
                Console.WriteLine($"{sehir.Key,-5}-" +
                    $"{sehir.Value,5}-"); //sehir bir dictinipry entrydir
            }
            //adana silindi
            Console.ReadKey();
        }
    }
}
