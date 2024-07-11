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
            //ctrl tab class lar arası gezinim
            //tanimlama 
            OgretimElemani ogrGor = new OgretimElemani();
            //Console.WriteLine(ogrGor); //namespace ve class basiyor
            //atama
            ogrGor.SicilNo = 101;
            ogrGor.ad = "Muhittin";
            ogrGor.soyAD="Atakul";
            ogrGor.cinsiyet = true;
            Console.WriteLine(ogrGor);
            Console.ReadKey();

            //tanim2
            var ogrGor2 = new OgretimElemani()
            {

                SicilNo = 102,
                ad = "Levent",
                soyAD = "atakul".ToUpper(),
                cinsiyet = true
            };
            Console.WriteLine(ogrGor2);
            Console.ReadKey();

            //tanim3
            var ogrGor3 = new OgretimElemani(103, "Melek", "Atakul".ToUpper(), false);
            Console.WriteLine(ogrGor3);


            Console.ReadKey();
        }
    }
}
