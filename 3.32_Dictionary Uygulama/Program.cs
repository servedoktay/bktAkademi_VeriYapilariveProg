using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._32_Dictionary_Uygulama
{
    internal partial class Program
    {
      
        static void Main(string[] args)
        {
            //dictinory
            var personelListesi = new Dictionary<int, Personel>()
            {
                {101,new Personel("Mehmet","Sonsoz",7500)},
                {102,new Personel("Oktay","Atakul",1000 )}
            };
            personelListesi.Add(100, new Personel("Zeynep", "Coskun", 5000));
            foreach(var personel in personelListesi)
            {
                Console.WriteLine(personel );
            }
           Console.ReadKey();
        }
    }
}
