using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._24_Metotlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //methodtasarimi();

            //methodlarin asiri yüklenmesi
            var odenecekMiktar = satisYap(100);
            Console.WriteLine("{0,5:0.##}", odenecekMiktar);

            var odenecekmiktar2 = satisYap(100, .1);
            Console.WriteLine("{0,5:0.##}",odenecekmiktar2);
            Console.ReadKey();
        }
        /// <aciklama>
        /// satis yapan fonk
        /// </summary>
        /// <param name="miktar"></alisveris tutari>
        /// <returns>kdv odenmis tutar</returns>
        static double satisYap(double miktar=0) //varsayilan deger verme
        {
            return miktar* 1.18;
        }
        /// <summary>
        /// Satis yapan fonksiyon (indirimli)
        /// </summary>
        /// <param name="miktar">Alisveris tutari</param>
        /// <param name="indirim">Indirim orani</param>
        /// <returns>KDV odenmis tutar (indirimli)</returns>
        static double satisYap(double miktar,double indirim)
        {
            return (miktar*(1.0 - indirim))*1.18;
        }

        private static void methodtasarimi()
        {
            //paremetre sayisini dinamik esnek hale getirtme
            double toplam = seriToplam(5.52, 15.12, 25.54, 13.13);
            Console.WriteLine("{0,5:0.##}", toplam); //noktadan sonra 2 karakter getir
            Console.WriteLine("{0,5}", toplam); //noktadan sonra 2 karakter getir
        }

        private static double seriToplam(params double[] seri)
        {
            //params kullan dizi göndericem demek
            double toplam = 0;
            foreach (double s in seri) 
            {
                toplam += s;
            }
            return toplam;
        }
    }
}
