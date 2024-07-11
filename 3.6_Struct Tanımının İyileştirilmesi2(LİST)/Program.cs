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
            //liste içerisinde olusturma
            var ogrenciList = new List<Ogrenci>()
            {
                //1 den fazla ctrl c yapıp ctrl+shift +v yap oncekilerin hepsini gor
                new Ogrenci(10, "oktay", "ATAKUL", true),
                new Ogrenci(11, "Burak", "ATAKUL", true),
                new Ogrenci(12, "sadettin", "ATAKUL", true),
                new Ogrenci(13, "meyem", "ATAKUL", false),
                new Ogrenci(14, "elif", "ATAKUL",false)
            };
            //foreach (var o in ogrenciList) { Console.WriteLine(o); }
            //alt 2
            ogrenciList.ForEach(o => Console.WriteLine(o));

            Console.ReadKey();
        }
    }
}
