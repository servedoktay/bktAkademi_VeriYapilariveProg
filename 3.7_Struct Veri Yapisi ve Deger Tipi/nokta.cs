namespace _3._7_Struct_Veri_Yapısı_ve_Değer_Tipi
{
    internal partial class Program
    {
        public struct nokta
        {
            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString()
            {
                //buytun turler objeden turer to stringi overridge ettik
                //OVERİDGE BELİRTİLEN DEGERLERİ EKRANA YAZDIRTMA
                return $"{X},{Y}";
            }
            //default ctor //struckda olmaz
            public nokta(int x,int y)
            {
                //tanimlama esnasında x ve y degeri veriyoruz
                X = x;
                Y = y;
               //ctor iki tab     
            }

            //yapimiza yeni uye -> metot.
            public void SetOrigin()
            {
                X = 0;
                Y = 0;
            }
            public void Degistir()
            {
                // x i y ile degistirmek
                var gecici = X;
                X = Y;
                Y= gecici;
            }
        }
    }
}
