using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._23_Stack_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yiginOrnek();
            var karakterYigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);
                Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi");
                Console.WriteLine($"yiğindaki Eleman Sayisi= {karakterYigini.Count}");
            }
            //diziye aktarma
            var dizi = karakterYigini.ToArray();
            Console.WriteLine("Yıgından Cikartmak icin tusa basin");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            //yıgından çıkartma
            for (int i = 90; i >= 65; i++)
                //{
                //    Console.WriteLine(karakterYigini.Pop()+"  çıkartildi");
                //}
                while (karakterYigini.Count > 0)
            {
             Console.WriteLine(karakterYigini.Pop()+"  çıkartildi");
             Console.WriteLine($"yiğindaki Eleman Sayisi= {karakterYigini.Count}");

            }


            Console.ReadKey();

        }

        private static void yiginOrnek()
        {
            var karakterYigini = new Stack<char>();

            //ekleme
            karakterYigini.Push('A');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('B');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('C');
            Console.WriteLine(karakterYigini.Peek());


            //çıkartma
            Console.WriteLine(karakterYigini.Pop() + "yığından çikartti.");
            Console.WriteLine(karakterYigini.Pop() + "yığından çikartti.");
            Console.WriteLine(karakterYigini.Pop() + "yığından çikartti.");
        }
    }
}
