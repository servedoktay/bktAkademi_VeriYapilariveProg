using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._26_Queue_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //queue 
            //tanımlama
            //sesli harfleri yazdırtma
            var karakterKuyrugu = new Queue<char>();

            //ekleme
            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('e');
            karakterKuyrugu.Enqueue('ı');
            karakterKuyrugu.Enqueue('i');          
            karakterKuyrugu.Enqueue('o');
            karakterKuyrugu.Enqueue('ö');
            karakterKuyrugu.Enqueue('u');
            karakterKuyrugu.Enqueue('ü');
            Console.WriteLine($"kuyrugun basındaki eleman:{karakterKuyrugu.Peek()}");
            var dizi=karakterKuyrugu.ToArray(); //diziye atama
            Console.WriteLine(karakterKuyrugu.Count);

            //cıkartma
            Console.WriteLine("Çikartildi\t"+karakterKuyrugu.Dequeue());

            //peek
            Console.WriteLine($"kuyrugun basındaki eleman:{karakterKuyrugu.Peek()}");

            Console.WriteLine(karakterKuyrugu.Count);





            Console.ReadKey();
        }
    }
}
