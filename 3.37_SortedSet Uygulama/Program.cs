using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._37_SortedSet_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random sayılardan olan kume ve o kumenın alt kumesı olusturulsun ve o olusturlan alt ümdeki uyulerın bensersız olsun
            var sayilar = new List<int>();
            var r = new Random();
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(r.Next(5,25)); //aralıgı kac olsun
                Console.Write($"{sayilar[i],-5}");
            }
            Console.WriteLine( );

            var bensersizSayiListesi=new SortedSet<int>(sayilar);

            Console.WriteLine();
            Console.WriteLine("\nBenzersiz Sayi Listesi\n");
            foreach (int item in bensersizSayiListesi)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\n");
            Console.Write("Benzersiz Sayilar  {0}",bensersizSayiListesi.Count);
            Console.ReadKey();
        }
    }
}
 