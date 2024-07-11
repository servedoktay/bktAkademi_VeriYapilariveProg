using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12_Diziler_ve_Alternatif_Dizi_Oluşturma_Yaklaşımları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array dizi|tanimlama
            //int[] dizi = new int[5];
            int[] sayilar = new int[] {5,3,8,10,2}; //alt2

            var numbers = Array.CreateInstance(typeof(int), 5); //alt3
            //atamasi
            numbers.SetValue(-5, 0); //eleman ve index 5 eleman 0 index
            numbers.SetValue(3, 1);
            numbers.SetValue(8, 2);
            numbers.SetValue(10, 3);
            numbers.SetValue(-2, 4);

            var arr = new ArrayList(sayilar); //tanim4
            for (int i = 0; i < sayilar.Length; i++)
            {
                //Console.WriteLine("sayilar[{0}]={1}-numbers[{0}]={2}",
                //    i,
                //    sayilar[i],
                //    numbers.GetValue(i));
                Console.WriteLine($"sayilar[{i}]=" +
                    $"{sayilar[i],3} - " +
                    $"numbers[{i}]=" +
                    $"{numbers.GetValue(i),-3} " +
                    $"arr[i]" +
                    $"{arr[i],3}");
                //2.gibi dizi olusturursa get demeliyim

                
            }
            Console.ReadKey();
        }
    }
}
