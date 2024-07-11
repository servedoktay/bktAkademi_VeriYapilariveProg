using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btkZafertekrar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //degiskentanimiveatama();
            int sayi = 5;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi + 2);
            Console.WriteLine(sayi*sayi);
            Console.WriteLine(sayi-5);
            Console.ReadKey();
        }

        private static void degiskentanimiveatama()
        {
            //
            /* basit degisken atama
            int sayi1;
            float pi = 3.14f;
            double pi2 = 3.14;
            char secim = 'e';
            string isim = "oktay";
            bool dogruMu = false;
            */
            string isim = "oktay";
            Console.WriteLine("Merhaba  " + isim);
            Console.WriteLine("Merhaba Sayin " + isim);
        }
    }
}
