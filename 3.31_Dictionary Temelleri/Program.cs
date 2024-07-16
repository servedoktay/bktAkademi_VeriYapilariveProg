using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._31_Dictionary_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dictionary
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332,"Konya" },
                {222,"Eskişehir"},
                {313,"Ankara" }
            };

            //ekleme
            telefonKodlari.Add(322,"Adana");
            telefonKodlari.Add(212, "İSTANBUL");
            telefonKodlari.Add(216, "İSTANBUL");

            //erişme
            telefonKodlari[222] = "Eses"; //keye gore eristik

            //containkey
            if (!telefonKodlari.ContainsKey(466)) {
                Console.WriteLine("\a466 alan kodu tanimli degil");
                telefonKodlari.Add(466, "Artvin");
                Console.WriteLine("Eklendi");
            }
            //contain deger
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\amalatya tanimli degil");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni Kod EKLENDİ");
            }

            //ÇIKARTMA
            telefonKodlari.Remove(322);
            //dolaşma
            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }

           

            Console.ReadKey();
        }
    }
}
