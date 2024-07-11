using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._13_Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPARATÖRLER
            int a, b;
            b = 10;
            a = 20;

            //aritmatik ifadeler
            //Console.WriteLine(a+b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //ilişkisel oparatörler
            //Console.WriteLine(a  > b);
            //Console.WriteLine(a < b);
            //Console.WriteLine(a >= b);
            //Console.WriteLine(a <= b);
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);

            //KOSUL
            Console.WriteLine(a>b &&a <5);
            Console.WriteLine(!(a > b && a < 5)); //PARANTEZ BASŞINA ! TERSİ

            Console.WriteLine(a < b || b > 5);



            Console.ReadKey();
        }
    }
}
