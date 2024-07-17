using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._40_HashSet_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hash set
            var sesliharfler = new HashSet<char>()
            {
                'e','ı','ö','o','i','u','ü','b'
            };
            koleksiyonyazdir(sesliharfler);
            //ekeleme
            sesliharfler.Add('a');
            koleksiyonyazdir(sesliharfler);

            //cıkartma
            sesliharfler.Remove('b');
            koleksiyonyazdir(sesliharfler);

            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++) alfabe.Add((char)i); //ascıı koda gore
            //alfabe.ForEach(x => Console.WriteLine(x)); //lambda

            koleksiyonyazdir(alfabe); //hata verir convert hatası interfacelerine bak getenuramator
            //ortak kontratlara bak f12:IEnumrable list ve hashsetteki

            //sadece turkce sesli harfleri iceren küme
            //sesliharfler.ExceptWith(alfabe);
            //Console.WriteLine("Alfabede yok");
            //Console.WriteLine();
            //koleksiyonyazdir(sesliharfler);

            //birlesme
            //sesliharfler.UnionWith(alfabe);
          
            //Console.WriteLine("BİRLESME");
            //Console.WriteLine();
            //koleksiyonyazdir(sesliharfler);

            //KESİSİM
            //sesliharfler.Intersect(alfabe);
            
            //Console.WriteLine("Alfabede yok");
            //Console.WriteLine();
            //koleksiyonyazdir(sesliharfler);

            //simetrik
            sesliharfler.SymmetricExceptWith(alfabe);
            
            Console.WriteLine("iki listede yok simetrik");
            Console.WriteLine();
            koleksiyonyazdir(sesliharfler);







            Console.ReadKey();
        }
        static void koleksiyonyazdir(IEnumerable koleksiyon)
        {
            //enurable ortakdır
            Console.WriteLine();
            int i = 0;
            foreach (char c in koleksiyon)
            {
                Console.Write($"{c,5}");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine($"Eleman SAyisi {i}");
            //Console.WriteLine($"eleman sayim={koleksiyon.Count}");
        }
    }
}
