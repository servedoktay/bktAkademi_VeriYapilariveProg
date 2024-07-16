using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3._34_SortedDictionary_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sorted dictioanray
            //kitap indexi olustur(web tek anlatan) ftp diye gecen kavram hangi sayfalarda geciyor html kacıncı sayfalarda geciyor css kacıncı sayfalarda geciyor
            //bu kavramlar kacıncı sayfada geciyor gecen tum sayfaları getir
            var kitapKavram=new SortedDictionary<string, List<int>>()
            {
                {"HTLM",new List<int>() {8,10,12} },
                {"Asp.net",new List<int>() {50,60,72} },
                {"Css",new List<int>() {70,80,90} },
                {"JQUERY",new List<int>() {3,5,15} },
                {"SQL",new List<int>() {70,80} }

            };

            kitapKavram.Add("Ftp", new List<int>() { 3, 5, 7 });


            foreach (var item in kitapKavram)
            {
                //Console.WriteLine(item); //value tipi geliyor kendisi degil
                Console.WriteLine(item.Key);
                //foreach (var item2 in item.Value)
                //{
                //    Console.WriteLine($"\t >{item2,-5} pp");
                //}
                //2.yol
                item.Value.ForEach(s => Console.WriteLine("\t >"+s));
            }
            Console.ReadKey();
        }
    }
}
