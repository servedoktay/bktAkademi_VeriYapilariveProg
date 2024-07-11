using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _3._7_Struct_Veri_Yapısı_ve_Değer_Tipi
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            ////ctrl tab class lar arası gezinim
            ////tanimlama 
            //OgretimElemani ogrGor = new OgretimElemani();
            ////Console.WriteLine(ogrGor); //namespace ve class basiyor
            ////atama
            //ogrGor.SicilNo = 101;
            //ogrGor.ad = "Muhittin";
            //ogrGor.soyAD="Atakul";
            //ogrGor.cinsiyet = true;
            //Console.WriteLine(ogrGor);
            //Console.ReadKey();

            ////tanim2
            //var ogrGor2 = new OgretimElemani()
            //{

            //    SicilNo = 102,
            //    ad = "Levent",
            //    soyAD = "atakul".ToUpper(),
            //    cinsiyet = true
            //};
            //Console.WriteLine(ogrGor2);
            //Console.ReadKey();

            //tanim3
            //var ogrGor3 = new OgretimElemani(103, "Melek", "Atakul".ToUpper(), false);
            //Console.WriteLine(ogrGor3);

            //kapali ekleme ogretim elemani listesi olustur
            var liste1 = new List<OgretimElemani>()
            {
                new OgretimElemani(100,"Muhittin","Atakul",true),
                new OgretimElemani(101,"Levent","Atakul",true),
                new OgretimElemani(102,"Melek","Atakul",false),
                new OgretimElemani(103,"Günay","Eker",false),
                new OgretimElemani(104,"Necdet","Atakul",true),

            };
            #region
            //foreach (var elem in liste1)
            //{
            //    Console.WriteLine(elem);               
            //}
            Console.WriteLine("Liste 1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            //List<OgretimElemani> liste2 = liste1;
            //kisasi
            var liste2 = liste1;
            Console.WriteLine("liste 2");
            liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
            #endregion
            //liste 2 ye eleman eklersem list 1 e eklermi
            liste2.Add (new OgretimElemani(106, "Cevdet", "Yuksel", true));
            liste1.RemoveAt(0); // liste 1 den eleman sil
            Console.ReadKey();
            Console.WriteLine("Ekleme Oldu");
            Console.WriteLine("Liste 1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            Console.WriteLine("Liste 2");
            liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            //yeni eklenen list1 de de gozuktu
            //list 1 de silinen list 2 de de silindi referans tipli demek
            //tanimli olduklari heap ayni adresde oldugu icn referans tiplidir degisken degisir ikisindednsole.ReadKey();
            //veri tabani yapisinda hiz 2 farkli kod blogu yerine tek yapmamizi saglıyor daha işlevsel fonk yazilmasini saglar
        }
    }
}
