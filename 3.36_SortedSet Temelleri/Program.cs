using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._36_SortedSet_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sorted set

            //tanimlama
            var list = new SortedSet<string>();

            //ekleme
            list.Add("Ahmet"); //ya true yada false olucak
            if (list.Add("Mehmet"))
            {
                Console.WriteLine("mehmet eklendi");
            }
            Console.WriteLine(list.Add("Ahmet")
                == true ? "Ahmet Eklendi":"Ekleme Başarisiz");
            list.Add("Sule");
            list.Add("Neslihan");
            list.Add("Fahrettin");
            list.Add("Fatih");
            list.Add("\n İsimler Listesi");
            //dolaşma
            foreach (string kisi in list) { Console.WriteLine(kisi); }

            //cıkartma
            list.Remove("Sule");
            Console.WriteLine("\nSilme İslemi Gerceklesti");
            foreach (string kisi in list) { Console.WriteLine(kisi); }

            //kucuk a olanlari sil
            //list.RemoveWhere(deger => deger.Contains("a"));
            //F İLE baslayanları sil
            list.RemoveWhere(deger => deger.StartsWith("F"));

            foreach (string kisi in list) { Console.WriteLine(kisi); }

            Console.WriteLine("Eleman Sayisi ...:{0}",list.Count);
            Console.ReadKey();


        }
    }
}
