using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._14_IF_ELSE_Yapısİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tekMiCiftMi();
            //mutlak();
            Console.WriteLine("Karakter Girisi Yapınız..:");
            var k = (char)Console.Read(); //cast işlemi yaptık
            if (char.IsDigit(k))
            {
                Console.WriteLine("rakam");
            }
            else if (char.IsLower(k))
            {
                Console.WriteLine("kucuk karakter");
            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine("buyuk karakter");
            }
            else
            {
                Console.WriteLine("bilinmeyen karakter");
            }
            //sayısal degerini getiriyor
            Console.WriteLine(k);
            Console.ReadKey();
        }

        private static void mutlak()
        {
            int s, mutlak;
            Console.WriteLine("Sayi giriniz..:");
            s = Convert.ToInt32(Console.ReadLine());
            if (s >= 0)
                Console.WriteLine($"|{s}|={s}");
            else if (s < 0)
            {
                mutlak = s * -1;
                Console.WriteLine("Mutlak deger {0} 'dir", mutlak);
            }
        }

        private static void tekMiCiftMi()
        {
            int sayi;
            Console.WriteLine("Sayi Giriniz..:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
                //Console.WriteLine("Çift..: {0}\a ", sayi);
                Console.WriteLine($"Çift..: {sayi}\a ");

            else Console.WriteLine($"{sayi} tek bir sayidir");
        }
    }
}
