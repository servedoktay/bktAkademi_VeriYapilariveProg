using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._20_Çok_Boyutlu_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foraeOrnek();
            //basitmatris();            
            //diogonel();
            //diogonelVeciftsifir();

            //cok boyutlu matrisde toplama

            double[,] matris = new Double[,]
     {
                { 1, 2, 3 },
                { 2, 3, 4 } ,
                { 3, 4, 5 } };

            double toplam = 0;

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matris[i, j] = -1;
                    }

                    if (matris[i, j] % 2 == 0)
                    {
                        matris[i, j] = 0;

                    }

                    toplam += matris[i, j];
                    Console.Write($"{matris[i, j],5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Toplam:{toplam}");

            Console.ReadKey();
        }

        private static void diogonelVeciftsifir()
        {
            // diogonel-1 ciftleri 0 yapan progaram
            double[,] matris = new Double[,]
       {
                { 1, 2, 3 },
                { 2, 3, 4 } ,
                { 3, 4, 5 } };
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matris[i, j] = -1;
                    }

                    if (matris[i, j] % 2 == 0)
                    {
                        matris[i, j] = 0;

                    }
                    Console.Write($"{matris[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        private static void diogonel()
        {
            //diogonel elemam 0,0 1,1,2,2 i == j ise diogonel adamdır
            double[,] matris = new Double[,]
       {
                { 1, 2, 3 },
                { 2, 3, 4 } ,
                { 3, 4, 5 } };
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matris[i, j] = -1;
                    }
                    Console.Write($"{matris[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        private static void basitmatris()
        {
            //cok boyutlu diziler
            double[,] matris = new Double[,]
            {
                { 1, 2, 3 },
                { 2, 3, 4 } ,
                { 3, 4, 5 } };          //, kac boyutlu tek , 2 boy dizi
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write($"{matris[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        private static void foraeOrnek()
        {
            //boyut bilgisi dişarıdan ve rakamlar random olsun
            Console.WriteLine("Dizi boyutunu giriniz:");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[boyut];
            var r = new Random();

            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = r.Next(1, 10);
            foreach (int s in sayilar)
            //koleksiyonlar icinde dolasmak icin diziler listeler
            {
                Console.WriteLine($"{s,5} {s * s,5}");
            }
            //foreach diger dongulere kıyasla daha konforludur
        }
    }
}
