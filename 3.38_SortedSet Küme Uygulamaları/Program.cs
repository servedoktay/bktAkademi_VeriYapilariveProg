using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._38_SortedSet_Küme_Uygulamaları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sorted kume uygulamaları
            //var a = new SortedSet<int>() { 1, 2, 3, 4 };
            var a = new SortedSet<int>(RasgeleSayiUret(10));
            //var b = new SortedSet<int> { 1, 2, 5, 6 };
            var b = new SortedSet<int>(RasgeleSayiUret(9));

            Console.WriteLine();
            Console.WriteLine("A KÜMESi");
            foreach (var item in a)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
            Console.WriteLine("B Kümesi");
            foreach(var item in b)
            {
                Console.Write($"{item}  ");

            }
            Console.WriteLine();

            ////union
            //a.UnionWith(b);
            //Console.WriteLine("A Ve B nin Birleşimi");
            //foreach (var s in a)
            //{
            //    Console.Write($"{s}  ");

            //}
            //Console.WriteLine();
            //Console.WriteLine("Toplam Eleman Sayisi= "+a.Count);
            //Console.WriteLine();

            //kesişim
            //Console.WriteLine("KESİŞİM");
            //a.IntersectWith(b);
            //foreach (var s in a)
            //{
            //    Console.Write($"{s}  ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Toplam Eleman Sayisi= " + a.Count);

            //SADECE A
            //a.ExceptWith(b); //sadece a
            //Console.WriteLine();
            //Console.WriteLine("Sadece A");
            //foreach (var s in a)
            //{
            //    Console.Write($"{s}  ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Toplam Eleman Sayisi= " + a.Count);

            //simetrik
            a.SymmetricExceptWith(b);
            Console.WriteLine();
            Console.WriteLine("Sadece A");
            foreach (var s in a)
            {
                Console.Write($"{s}  ");
            }
            Console.WriteLine();
            Console.WriteLine("Toplam Eleman Sayisi= " + a.Count);

            //A.IsSubsetof(b) aa b nın bır alt kumesimi bool doner altkume kontrolu
            Console.ReadKey();
        }
        static List<int> RasgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0, 1000));
            }
            return list;
        }
    }
}
