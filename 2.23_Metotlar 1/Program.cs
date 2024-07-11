using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._23_Metotlar_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //METOTLAR
            //basitmethod();
            //int buyuk=Karsilastir(13, 5);
            //Console.WriteLine(buyuk);
            var x= KareAl(3);
            double y = KareAl(x);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("Method Sonu");

            Console.ReadKey();
        }
        public static void basitmethod()
        {
            //basit metot
            Console.WriteLine("Method Çalişti");
            Console.WriteLine(".");
            Console.WriteLine(".");            
        }
        /// <summary>
        /// method 2 inti karsilastirir ve enb döndürür
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static int Karsilastir(int s1,int s2)
           
        {
            //if (s1 > s2)
            //    return s1;
            //else return s2;

            //refac
            return s1>s2 ? s1: s2;
            /*Eğer s1 değeri s2 değerinden büyükse (s1 > s2), s1 değeri döndürülür.
              Aksi takdirde (s1 > s2 değilse), s2 değeri döndürülür.*/

        }
        static double KareAl(double sayi)
        {
            double kare=Math.Pow(sayi, 2); //kare alma
            //double kare =sayi*sayi
            return kare;
        }
    }
}
