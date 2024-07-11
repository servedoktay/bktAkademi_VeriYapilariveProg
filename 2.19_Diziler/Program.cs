    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._19_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //basit_dizi();
            //farkliDiziTanimlamalari();
           
            int[] numaralar = new int[] { 1, 2, 3, 5, 6, 7, 8, 9 };
         
            //index kullanma

            for (int i = 0; i < numaralar.Length; i++)
            {
                //string interpolasyon
                Console.WriteLine($"Numaralar[{i}]={numaralar[i]}");
            }

            Console.ReadKey();
        }

        private static void farkliDiziTanimlamalari()
        {
            //tanımlama ve baslatma
            //int[] numaralar = new int[3];

            //tamımlama baslatma atama 
            //int[] numaralar = new int[3] { 1, 2, 3 };

            //tanımlma baslatma atama DİNAMİK
            int[] numaralar = new int[] { 1, 2, 3, 5, 6, 7, 8, 9 };
            //int[] numaralar = { 1, 2, 3, 5, 6, 7, 8, 9 };


            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine(numaralar[i]);
            }
        }

        private static void basit_dizi()
        {
            //tanımlama
            //int numara1= 1;
            //int numara2 = 1;
            //int numara = 3;
            //amac aynı turledkı verileri bır arada toplayıp index eklemek
            int[] numaralar;
            //deger tipli referans tipli ifadeler 
            //baslatma referans tipliyse
            numaralar = new int[3];
            numaralar[0] = 3;
            numaralar[1] = 5;
            numaralar[2] = 7;

            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine(numaralar[i]);
            }
        }
    }
}
