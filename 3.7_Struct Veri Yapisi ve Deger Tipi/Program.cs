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
         //struck deger tipli
            var n1=new nokta(3,4);  //tanimlama  //yapilandirici
            Console.WriteLine($"n1={n1}"); //0,0 goruruz

            n1.Degistir();
            Console.WriteLine($"n1={n1}"); //yerlerini degistirdi

            //2.nokta bilg n1 den al
            var n2 = n1;          

           Console.WriteLine($"n2={n2}");

            n2.X = -1 * n2.X;
            Console.WriteLine($"n1={n1}");
            Console.WriteLine($"n2={n2}");

            //n2 degisince n1 uzerınde etkisi yoktur
         


            Console.ReadKey();

        }
    }
}
