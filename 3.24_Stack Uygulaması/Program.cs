using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._24_Stack_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanının gırdıgı sayı once bırler sonra onlar ve sonra yuzler bas yıgına eklet ve tersten geri getir
            //orn 432 400 30 2 olarak ayıklamak
            Console.WriteLine("Bir Sayi Giriniz");
            int sayi=Int32.Parse(Console.ReadLine());
            
            var sayiYigini=new Stack<int>();
            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }
            int i = 0;
            int n = sayiYigini.Count - 1;
            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"\t{s,7} x {Math.Pow(10,n-i),7}={s*Math.Pow(10,n-1),7}");
                i++;
            }
            Console.ReadKey();
        }
    }
}
