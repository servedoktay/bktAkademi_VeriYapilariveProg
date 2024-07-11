using System;

namespace _3._7_Struct_Veri_Yapısı_ve_Değer_Tipi
{
    internal partial class Program
    {
        public struct Ogrenci //yeni yapı tanimladik
        {
            //ustune gelip ctrl. move aynı paket ıcerisinde yeni cs olusturdurk
            //yapilandirici metot constructor ctor kısaltmasi
            public Ogrenci(int ogrenciNo, string ogrenciad, string soyad, bool cinsiyet=true)
            {
                //varsayilan deger olursa cinsiyeti true belirtilmesi
                
                //Console.WriteLine("OTO CALISTI");
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
            public string soyad { get; set; }

            public bool cinsiyet { get; set; }
            //private ozel demek dısarı cıkmasın public disaridan erisimdir

            //gecersiz kılmak/ezmek/overridge
            //ogrenci nesneleri ekrana basıldıgında ne gostericek
            public override string ToString()
            {
                //return $"{ogrenciNo} ";
                //return $"{ogrenciNo,-5} {ogrenciad,-5} "; //hem no hem ad getir bana
                //return $"{ogrenciNo,-5} " +
                //    $"{ogrenciad,-10} " +
                //    $"{soyad,-10} " +
                //    $"{cinsiyet,-5} "; //cinsiyet ve soyad ekledim
                return $"{ogrenciNo,-5} " +
                   $"{ogrenciad,-10} " +
                   $"{soyad,-10} " +
                   string.Format("{0,-8}", cinsiyet == true ? "bay" : "bayan");
                    //cinsiyet true mı sorluga true sa yerıne erkek degilse bayan yazar sart soru isareti "dogrusu":"dıger olasılık"
                   //$"{cinsiyet==true ?"Bay":"Bayan",-5} "; //erkekmi diye sor
                //ne gostericem ben 
            }



        }
    }
}
