using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13_Array_Class_Metotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array dizi|tanimlama
            //int[] dizi = new int[5];
            int[] sayilar = new int[] { 5, 3, 8, 10, 2,18,23,44,55,6,34,19 }; //alt2

            var numbers = Array.CreateInstance(typeof(int), sayilar.Length); //alt3
            //atamasi
            //numbers.SetValue(-5, 0); //eleman ve index 5 eleman 0 index
            //numbers.SetValue(3, 1);
            //numbers.SetValue(8, 2);
            //numbers.SetValue(10, 3);
            //numbers.SetValue(-2, 4);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    numbers.SetValue(sayilar[i], i);//numbersa sayilardaki elemanlari atmak
            //}
            //ÇEVRİMSİZ KOPYALAMA
            sayilar.CopyTo(numbers,0); //(nereye kopyalanmali ve nerden baslamali)

            var arr = new ArrayList(sayilar); //tanim4

            arr.Sort(); //tanim 4 de sadece direkt sort ediyor 
            //PEKİ DİZİDE NASİL YAPILIR
            Array.Sort(sayilar); //sayilar siraladi
            Array.Sort(numbers);

            Array.Clear(sayilar,2,3);//eleman silme //(silinecek baslancak index kac eleman) 

            //belirli eleman listenin kacinci elamanidir
            var x=Array.IndexOf(sayilar, 44); //dizi ne arıyorum
            Console.WriteLine(x);
            Console.WriteLine(Array.IndexOf(sayilar, 100)); //olmayan bisey ararsa -1 basar
            
            for (int i = 0; i < sayilar.Length; i++)
            {
                //Console.WriteLine("sayilar[{0}]={1}-numbers[{0}]={2}",
                //    i,
                //    sayilar[i],
                //    numbers.GetValue(i));
                Console.WriteLine($"sayilar[{i}]=" +
                    $"{sayilar[i],3} - " +
                    $"numbers[{i}]=" +
                    $"{numbers.GetValue(i),3} " +
                     $"arr[{i}]={arr[i],3}");
                //2.gibi dizi olusturursa get demeliyim


            }
            //sirali gelmesini istiyorsam
           
            Console.ReadKey();
        }
    }
}
