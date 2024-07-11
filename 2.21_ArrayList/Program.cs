using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._21_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arraylist

            //tanimlamaekleme();

            //tanimlama_addrange();

            var a = new ArrayList()
            {
                10,"btk akademi",true,'e'
            };
            foreach (var i in a)
            {
                Console.Write($"{i}  ");
            }

            //dizi icersindeki elemanlari arrayliste atma
            int[] sayilar = new int[] { 23, 44, 55 };
            //colection dizi ekleme
            a.AddRange(sayilar);
            Console.WriteLine();
            foreach (var i in a)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();

            //arrayliste erisme
            Console.WriteLine(a[4]);

            //erisme ve atama 
            //cast yapmadıgımız icin hata verir
            //int x = ArrayList[0]; //unboxing 
            int x = (int)a[0];
            //cast yaptık
            Console.WriteLine(x+10);

            //eleman silme cikartma
            //a.Remove(10); //degeri 10 olani atar
            //a.RemoveAt(1); //indexi 1 olani atar

            //3.ve 5. index arasindaki elemanlari silme
            a.RemoveRange(3, 3); //3.elemandan basla 3 eleman sil
            Console.WriteLine();
            foreach (var i in a)
            {
                Console.Write($"{i}  ");
            }
            Console.ReadKey();
        }

        private static void tanimlama_addrange()
        {
            //farklitanimlama
            var a = new ArrayList()
            {
                10,"btk akademi",true,'e'
            };
            foreach (var i in a)
            {
                Console.Write($"{i}  ");
            }

            //dizi icersindeki elemanlari arrayliste atma
            int[] sayilar = new int[] { 23, 44, 55 };
            //colection dizi ekleme
            a.AddRange(sayilar);
            Console.WriteLine();
            foreach (var i in a)
            {
                Console.Write($"{i}  ");
            }
        }

        private static void tanimlamaekleme()
        {
            //tanimlama
            var a = new ArrayList();
            //ekleme
            a.Add(10);
            a.Add("Btk Akademi");
            a.Add(true);
            a.Add('o');
            //HER TURDEN OLUSUR

            foreach (var i in a)
            {
                Console.Write($"{i}  ");
            }
        }
    }
}
