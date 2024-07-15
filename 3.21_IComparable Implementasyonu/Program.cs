using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _3._21_IComparable_Implementasyonu
{
    internal class Program
    {
        public interface ISehir
        {
            //kontrat
            void Tanit();
            void NufusBilgisiGetir(int plakaNo);
        }
        public class Sehir:IComparable<Sehir> //devral
            //bu kontrata uymak istiyorum
        {
            public int Plaka { get; set; }
            public string Sehirler { get; set; }
            public Sehir(int plaka, string sehirler)
            {
                Plaka = plaka;
                Sehirler = sehirler;
            }

            public override string ToString()
            {
                return $"{Plaka,-5} {Sehirler,-5}";
            }

            int IComparable<Sehir>.CompareTo(Sehir other)
            {
                //int donen yenı ınte sahıbız
                if (this.Plaka < other.Plaka)
                {
                    return -1;
                }
                else if (this.Plaka == other.Plaka)
                {
                    return 0;
                }
                else 
                {
                    return 1;
                }
                //karsilastirila bilirlik ozelligi plakaya gore
            }
            //ctrl nokta ile implemented ettik
            //public void Tanit()
            //{
            //    throw new NotImplementedException();
            //}

            //public void NufusBilgisiGetir(int plakaNo)
            //{
            //    throw new NotImplementedException();
            //}
        }
        static void Main(string[] args)
        {
            var sayilar = new List<int>() { 53, 40, 14, 2, 3, 12, 15 };
            sayilar.Sort();//sırala
            sayilar.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();
            Console.WriteLine();
            //sehirler
            var sehirler = new List<Sehir>()
            {
                new Sehir(6,"Ankara"),
                new Sehir(34,"İstanbul"),
                new Sehir(55,"Samsun"),
                new Sehir(23,"Elazığ"),
                new Sehir(44,"Malatya")

            };
            sehirler.Sort(); //sıralamak istedim hata veriyor dizideki 2 elemanı karsılastırken basarızsız oldum dıyor
            //interfaceleri sınıfıma uyguluyoruz
            sehirler.ForEach(s => Console.WriteLine(s));

            Console.ReadKey();
        }
    }
}
