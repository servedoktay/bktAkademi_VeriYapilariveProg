using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _2._11_Karakter_Sabitleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //basitdegisken();
            //escape
            string ifaden,ifadet;
            ifaden = "\nbtk \nakademi \nprogramlama \nöğreniyorum";
            ifadet = "\tbtk \takademi \tprogramlama \töğreniyorum";
            Console.WriteLine(ifaden.ToUpper());
            Console.WriteLine(ifadet.ToUpper());


            Console.ReadKey();

        }

        private static void basitdegisken()
        {
            int sayi = 3;
            Console.WriteLine(sayi);
            /*.WriteLine(sayi+2);
            // acıklama oldu Console.WriteLine(sayi*sayi);
            // acıklama oldu Console.WriteLine(sayi-5);
            sadece en üst calısır ekrana sayi 3 yazar*/

            //refactoring daha iyi nasıl yazarım iyilestirebilirmiyim
        }
    }
}
