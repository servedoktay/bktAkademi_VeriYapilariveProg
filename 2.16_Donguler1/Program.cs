using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._16_Donguler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //sonsuz while
            //sonsuz(i);
            int ct, tt;
            ct = default;
            tt = default;
            while (i < 10)//0 dan 10a kadar olan kodları yazdırır
            {
                if (i % 2 == 0)
                {
                    ct += i;
                    Console.WriteLine($"Cift:{i}");
                }
                else 
                {
                    tt += i;
                    Console.WriteLine($"Tek:{i}");

                }
                i++;                
            }
            Console.WriteLine($"Tekler Toplamı={tt} \nCift Toplam={ct}");
            Console.ReadKey();
        }

        private static void sonsuz(int i)
        {
            int adet = 0;
            while (i < 10)
            {
                adet++;
                Console.WriteLine("Döngü Bloğu!{0} kez döndü", adet);
            }
        }
    }
}
