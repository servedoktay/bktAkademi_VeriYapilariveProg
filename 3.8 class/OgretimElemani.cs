using System;

namespace _3._7_Struct_Veri_Yapısı_ve_Değer_Tipi
{
    internal partial class Program
    {
        public class OgretimElemani
        {
            public int SicilNo { get; set; }
            public string ad { get; set; }
            public string soyAD { get; set; }
            public bool cinsiyet { get; set; }
            //ctor kisaltmasi
            //default consturactor herhangi parametre yoktur
            public OgretimElemani()
            {
                
            }

            public OgretimElemani(int sicilNo, string ad, string soyAD, bool cinsiyet)
            {
                //propları secip oto olustuyor ctrlç. generate consturactor
                SicilNo = sicilNo;
                this.ad = ad;
                this.soyAD = soyAD;
                this.cinsiyet = cinsiyet;
            }

            //public OgretimElemani(int sicilno,string adi,string soyadi,bool cinsiyeti)
            //{
            //    //3.farkli tanim icin olmali
            //    SicilNo = sicilno;
            //    ad = adi;
            //    soyAD = soyadi;
            //    cinsiyet = cinsiyeti;
            //}
            //bos satira gel ctrl . generete overrade
            public override string ToString()
            {
                return $"{SicilNo,-10}" +
                   $"{ad,-10}" +
                    $"{soyAD,-10}" +                    
                    string.Format("{0,-8}", cinsiyet == true ? "Erkek" : "Kadin");
            }
            //ezmek
            //public override string ToString()
            //{
            //    return $"{ad}+" +
            //        $"{soyAD}+" +
            //        string.Format("{0,-8}",cinsiyet==true ? "Erkek":"Kadin");
            //}

        }
    }
}
