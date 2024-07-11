using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._16_Donguler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //basitbirdenona();
            //birdenonakadarkare();
            //ters();
            //dwhile();

            Console.ReadKey();
        }

        private static void dwhile()
        {
            //klavyeden girilen n degerine kadar cift sayilari yazdıran program
            int n;
            int i = 2;
            Console.WriteLine("Sayi Girin:");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("{0,-3}", i);
                i = i + 2;
                // i+=2;
            } while (i <= n);
        }

        private static void ters()
        {
            //tersten
            int i = 10;
            while (i >= 1)
            {
                Console.WriteLine("{0,-3} {1,-3}", i, i * i);
                i--;
            }
        }

        private static void birdenonakadarkare()
        {
            int i = 1;
            //1 den 10 a kadar ekranda göster yan yana
            while (i <= 10)
            {
                Console.WriteLine("{0,-3} {1,-3}", i, i * i); //0 gelen degisken , -3 ayrılan yer sola hizalar - olursa sola hizalar
                                                          // 1 gelen yeni degisken -3 ayrılan yer 
                i++;
                // i=i+1;
                // sayac +=1;
            }
            Console.ReadKey();
        }

        private static void basitbirdenona()
        {
            int i = 1;
            //1 den 10 a kadar ekranda göster yan yana
            while (i <= 10)
            {
                Console.Write("{0,5}", i); //0 gelen degisken , 5 ayrılan yer sağa hizalar - olursa sola hizalar

                i++;
                // i=i+1;
                // sayac +=1;
            }
        }
    }
}
