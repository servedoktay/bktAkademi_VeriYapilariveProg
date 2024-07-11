using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._15_Switch_Case_Yapısı_ENUM_
{
    internal class Program
    {
        enum ISlemler
        {
            //liste olusturma
            Topla,
            Cikar,
            Carp,
            Bol
        }
        static void Main(string[] args)
        {
            //dört işlem secme
            int s1 = 10, s2 = 20;
            //ISlemler secim = (ISlemler)1; //her 2 türkde aynı olması icin
            Console.WriteLine("Secim Yapınız:");
            Console.WriteLine("1 - Topla");
            Console.WriteLine("2 - Çıkar");
            Console.WriteLine("3 - Çarp");
            Console.WriteLine("4 - Böl");
            Console.WriteLine("Seciminiz..:");
            int girilen=Convert.ToInt32(Console.ReadLine());
            girilen = girilen - 1; //index 0 dan basladıgı iciin
            ISlemler secim = (ISlemler)girilen;
            switch (secim)
            {
                case ISlemler.Topla:
                    Console.WriteLine($"{s1}+{s2}={s1+s2}");
                    break;
                case ISlemler.Cikar:
                    Console.WriteLine($"{s1}-{s2}={s1 - s2}");
                    break;
                case ISlemler.Carp:
                    Console.WriteLine($"{s1}*{s2}={s1 * s2}");
                    break;
                case ISlemler.Bol:
                    Console.WriteLine($"{s1}/{s2}={s1 / s2}");
                    break;
                default:
                    Console.WriteLine("\a Gecersiz İslem");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
