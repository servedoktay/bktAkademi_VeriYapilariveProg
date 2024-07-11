using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._22_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //listeTanimlama();
            
            List<int> sayilar = new List<int>() {10,15,20 };
            //var sayilar=new list<int>();
            int x = 55;
            //int[] seri = new int[] { 70, 80, 90 }; //dizi
            ////ekleme
            //sayilar.Add(10);
            //sayilar.Add(15);
            //sayilar.Add(20);
            sayilar.Add(x);

           /* //dizideki elemanı liste ekleme
            foreach (int s in seri)
            {
                sayilar.Add(s);
            }*/ //yerine
            //sayilar.AddRange(seri); //tipi dizi olan degiskeni eklemek
            sayilar.AddRange(new int[] { 40, 50, 60 });

            //araya ekleme
            sayilar.Insert(3, 0); //3.elemandan sonra 0 ekle
            sayilar.InsertRange(4, new int[] { 80, 90 });
            foreach (int s in sayilar)
            {
                Console.Write($"{s,-5}");
            }
            Console.WriteLine();
            //atma           
            sayilar.RemoveAt(3); //belirtilen indexli sayiyi atma
            sayilar.RemoveAt(sayilar.IndexOf(55)); // 55 index no bul ve sil
            foreach (int s in sayilar)
            {
                Console.Write($"{s,-5}");
            }


            Console.ReadKey();
        }

        private static void listeTanimlama()
        {
            //liste tanimlama
            List<int> sayilar = new List<int>();
            //var sayilar=new list<int>();

            //ekleme
            sayilar.Add(10);
            sayilar.Add(15);
            sayilar.Add(20);

            foreach (int s in sayilar)
            {
                Console.Write($"{s,-5}");
            }
        }
    }
}
