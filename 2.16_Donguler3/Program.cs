using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._16_Donguler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for
            //basitfor();
            //birdenOnaKadarKare(args);

            //girilen aralıktaki degerleri yazdırma
            //belirliaralik();
            //basitcont();
            //cont2();
            //icice();
            //icice2();
            //iciceyildizucgen();

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <n; i++) // iç içe for carpımdır
            {
                for (int j = 0; j <= i; j++) //i j yi kısıtlıyor 
                {
                    //matris temeli
                    Console.Write("*"); //satir sutun yazma
                }
                Console.WriteLine(); //1 alt satıra indirtti

            }
            Console.ReadKey();
        }

        private static void iciceyildizucgen()
        {
            int n = 5;
            for (int i = 0; i < n; i++) // iç içe for carpımdır
            {
                for (int j = 0; j <= i; j++) //i j yi kısıtlıyor 
                {
                    //matris temeli
                    Console.Write("*"); //satir sutun yazma
                }
                Console.WriteLine(); //1 alt satıra indirtti

            }
        }

        private static void icice2()
        {
            int n = 5;
            for (int i = 0; i < n; i++) // iç içe for carpımdır
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" {0},{1}", i, j); //satir sutun yazma
                }
                Console.WriteLine(); //1 alt satıra indirtti

            }
        }

        private static void icice()
        {
            //icice for    
            int n = 5;
            for (int i = 0; i < n; i++) // iç içe for carpımdır
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine(); //1 alt satıra indirtti

            }
        }

        private static void cont2()
        {
            int a, b;
            Console.WriteLine("aralık girin");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                if (i == 100)
                    continue; //atla dongunun sonuna git
                Console.WriteLine("{0,3} ", i);
            }
        }

        private static void basitcont()
        {
            //3 ve 3 un katıysa yazdırma CONTİNUE
            int a, b;
            Console.WriteLine("aralık girin");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                if (i % 3 == 0)
                    continue; //atla dongunun sonuna git

                Console.WriteLine("{0,3} ", i);
            }
        }

        private static void belirliaralik()
        {
            int a, b;
            Console.WriteLine("aralık girin");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                Console.WriteLine("{0,3} ", i);
            }
        }

        private static void birdenOnaKadarKare(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0,3} {1,3}", i, i * 3);
            }
        }

        private static void basitfor()
        {
            //for (int i = 0; i < 100; i+=5)
            //{
            //    Console.WriteLine(i);
            //}
            for (int i = 100; i >= 0; i -= 5) //tersi
            {
                Console.WriteLine(i);
            }
        }
    }
}
