using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._19_SortedList_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kitap icin icindekiler uygulaması ayarlamak
            var kitapicerigi = new SortedList();
            kitapicerigi.Add(1, "Onsoz");
            kitapicerigi.Add(50, "Degiskenler");
            kitapicerigi.Add(40, "Döngüler");
            kitapicerigi.Add(60, "İlişkisel oparatörler");
            kitapicerigi.Add(45, "oparatörler");
            Console.WriteLine("İÇİNDEKİLER");
            Console.WriteLine(new string('-',25));

            Console.WriteLine($"{"Konular",-30}{"Sayfalar",5}");
            foreach (DictionaryEntry item in kitapicerigi)
            {
                Console.WriteLine($"{item.Value,-30} {item.Key,5} ");
            }            

            Console.ReadKey();
        }
    }
}
