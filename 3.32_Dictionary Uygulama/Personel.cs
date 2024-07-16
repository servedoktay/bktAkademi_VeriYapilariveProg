namespace _3._32_Dictionary_Uygulama
{
    internal partial class Program
    {
        public class Personel
        {
            public Personel(string adi, string soyad, decimal maas)
            {
                Adi = adi;
                Soyad = soyad;
                this.maas = maas;
            }

            public int SicilNo { get; set; }
            public string Adi { get; set; }
            public string Soyad { get; set; }

            public decimal maas { get; set; }

            public override string ToString()
            {
                return $"{Adi,-10},{Soyad,-15},{maas,-10}";
            }

        }
    }
}
