using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7_Struct_Veri_Yapısı_ve_Değer_Tipi
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            //struck
            Ogrenci ogr = new Ogrenci();//yeni nesne uret demek
            ogr.ogrenciNo = 10; //tanimla kullan
            ogr.ogrenciad = "oktay";
            ogr.soyad = "atakul";
            ogr.cinsiyet = true;
            

            //alt kullanma
            var ogr2 = new Ogrenci()
            {
                ogrenciNo = 11,
                ogrenciad = "elif",
                soyad = "atakul",
                cinsiyet = false
            };


            //yapilandiri metot ctrl.generete cons sec
            //alt 3
            var ogr3 = new Ogrenci(12, "Burak", "ATAKUL", true);

            //belirli olan
            var ogr4 = new Ogrenci(13, "Sadettin", "atakul");

            //ezme yaptıgımmız ıcın bunlara gerek yok overridge

            //Console.WriteLine($"{ogr.ogrenciNo} " +
            //    $"{ogr.ogrenciad} {ogr.soyad} " +
            //    $"{ogr.cinsiyet}");

            //Console.WriteLine($"{ogr2.ogrenciNo} " +
            //    $"{ogr2.ogrenciad} {ogr2.soyad} " +
            //    $"{ogr2.cinsiyet}");


            //Console.WriteLine($"{ogr3.ogrenciNo} " +
            //  $"{ogr3.ogrenciad} {ogr3.soyad} " +
            //  $"{ogr3.cinsiyet}");

            //Console.WriteLine($"{ogr4.ogrenciNo} " +
            //  $"{ogr4.ogrenciad} {ogr4.soyad} " +
            //  $"{ogr4.cinsiyet}");

            //ezme yaptıgımmız ıcın bunlara gerek yok overridge
            //sadece numara
            //overridge metonuna ad ekleyınce adida getiriyor
            //en son cinsiyet ve soyad da ekledim
            //Ternary kullanıp true ise bay false ise bayanb yazdık

            Console.WriteLine(ogr);
            Console.WriteLine(ogr2);
            Console.WriteLine(ogr3);
            Console.WriteLine(ogr4);
            Console.ReadKey();
        }
    }
}
