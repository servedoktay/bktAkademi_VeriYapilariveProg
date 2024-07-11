using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5_Struct_Temelleri
{
    internal class Program

    {
        public struct Ogrenci //yeni yapı tanimladik
        {
            public Ogrenci(int ogrenciNo, string ogrenciad, string soyad, bool cinsiyet)
            {
                //yapilandiri metot ctrl.generete cons sec
                //geri donus turu yok
                Console.WriteLine("OTO CALISTI");
                this.ogrenciNo = ogrenciNo;
                this.ogrenciad = ogrenciad;
                this.soyad = soyad;
                this.cinsiyet = cinsiyet;
            }

            //1 veya birden fazla veri turu varsa  bunları bırlestırıp yenı verı turu kullanma
            //yerlesık verı turlerı ısı gormuyorsa
            //class referans tipli
            //struck deger tiplidir

            //prop yaz
            public int ogrenciNo { get; set; } //public heryerden erisebilme
                                               //property-özellik
                                               //int degerde ogrenci no olusturduk
                                               //set dişaridan deger atamak demek kapsulleme
                                               //get okuma icerideki degeri okur

            public string ogrenciad { get; set; }
            public string  soyad { get; set; }

            public bool cinsiyet { get; set; }
            //private ozel demek dısarı cıkmasın public disaridan erisimdir
        }
        
        static void Main(string[] args)
        {
            //struck
            Ogrenci ogr = new Ogrenci();//yeni nesne uret demek
            ogr.ogrenciNo = 10; //tanimla kullan
            ogr.ogrenciad = "oktay";
            ogr.soyad = "atakul";
            ogr.cinsiyet = true;
            Console.WriteLine($"{ogr.ogrenciNo} "+ 
                $"{ogr.ogrenciad} {ogr.soyad} " +
                $"{ogr.cinsiyet}");

            //alt kullanma
            var ogr2 = new Ogrenci()
            {
                ogrenciNo = 11,
                ogrenciad="elif",
                soyad="atakul",
                cinsiyet=false
            };
            Console.WriteLine($"{ogr2.ogrenciNo} " +
                $"{ogr2.ogrenciad} {ogr2.soyad} " +
                $"{ogr2.cinsiyet}");

            //yapilandiri metot ctrl.generete cons sec
            //alt 3
            var ogr3 = new Ogrenci(12,"Burak","ATAKUL",true);
            Console.WriteLine($"{ogr3.ogrenciNo} " +
              $"{ogr3.ogrenciad} {ogr3.soyad} " +
              $"{ogr3.cinsiyet}");

            Console.ReadKey();
        }
    }
}
