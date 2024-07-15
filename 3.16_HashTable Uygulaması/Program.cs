using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._16_HashTable_Uygulaması
{
    internal class Program
    {
        //web sayfasında url bılgılerı arat 
        //btk akademiden yeni eğitimler
            //..../btkakedemiden-yeni_egitimler.....
            //url olusturmak ıcın algoritma 
            //turkce ve ozel karakterleri almıcak
        static void Main(string[] args)
        {
            //okuma
            Console.WriteLine("Baslik Giriniz");
            string baslik = Console.ReadLine();

            //kucultme
            baslik = baslik.ToLower();

            //hastable manipule etmek
            var karakterSeti = new Hashtable()
            {
                {'ç','c'},
                {'ı','i' },
                {'ö','o'},
                {'ü','u'},
                {' ','-'},
                {'ğ','g'},
                { '/','-'}

            };


        }
    }
}
