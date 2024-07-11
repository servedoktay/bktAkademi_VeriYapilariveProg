using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._12_Dize_Değişmezleri_ve_Sabit_Tanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ortuludegisken();
            //string methodları basit
            string ifade = " Merhaba Programlama Dünyası. ";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length); 
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade[0]);
            Console.WriteLine(ifade[1]);
            Console.WriteLine(ifade[ifade.Length-1]);
            //bosluklarda karakter sayilır
            Console.ReadKey();
        }

        private static void ortuludegisken()
        {
            //ortulu degisken
            //string ifade = Console.ReadLine();  //klavyeden girilen degeri al ve ifade icinde sakla
            var ifade2 = Console.ReadKey(); //gelen deger consolekeyinfodur string degıldır


            Console.WriteLine(ifade2.Key); //büyütüp getirir
            Console.WriteLine(ifade2.KeyChar); //direkt getirir
        }
    }
}
