using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._27_Queue_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sesli harfleri listede tut sesli harfleri tek tek kurtuga ekliyimmi sor
            //e derse ekle h derse ekleme
            var sesliHarfler = new List<char>() { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            var kuyruk=new Queue<char>();
            ConsoleKeyInfo secim;
            foreach(char c in sesliHarfler)
            {
                Console.WriteLine();
                Console.WriteLine($"{c,-5} kuyruga eklensinmi?[e-h]");
                secim = Console.ReadKey();
                Console.WriteLine();
                if (secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(c);
                    Console.WriteLine($"\n{c,5} kuyruğa eklendi");
                    Console.WriteLine($"Kuyruktak eleman sayisi={kuyruk.Count}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Kuyruktan Elemanları Kaldırılmasi için esc bassın:");
            secim = Console.ReadKey();
            if (secim.Key==ConsoleKey.Escape)
            {
                Console.WriteLine();
                while (kuyruk.Count > 0)
                {
                    Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan cıkartlıyor");
                    Console.WriteLine($"{kuyruk.Dequeue()},5 kutruktan cikti");
                    Console.WriteLine($"Kuyruktak eleman sayisi={kuyruk.Count}");

                }

                Console.WriteLine("\n Kuyruktan Çikartma tamamlandı");
            }

            Console.WriteLine("PROGRAM BİTTİ");
            Console.ReadKey();
        }
    }
}
