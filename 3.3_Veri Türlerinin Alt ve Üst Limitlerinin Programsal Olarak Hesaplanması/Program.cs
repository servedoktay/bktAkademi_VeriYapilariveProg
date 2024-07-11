using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_Veri_Türlerinin_Alt_ve_Üst_Limitlerinin_Programsal_Olarak_Hesaplanması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 bit int 

            //sbyte mın ve max degerleri gorme
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt Limit       :{SByte.MinValue,20}");
            Console.WriteLine($"Üst Limit       :{SByte.MaxValue,20}");
            Console.WriteLine($"    Boyut       :{sizeof(SByte),20}");
            Console.WriteLine();
            Console.ReadKey();

            //unsigned işaretli sayilar
            //unsignet 8 bit integer
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"ALT Limit       :{Byte.MaxValue,20}");
            Console.WriteLine($"Üst Limit       :{Byte.MaxValue,20}");
            Console.WriteLine($"    Boyut       :{sizeof(SByte),20}");
            Console.WriteLine();
            Console.ReadKey();

            //unsignet 16-bit integer //İŞARETLİ + VE -
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"ALT Limit       :{Int16.MaxValue,20}");
            Console.WriteLine($"Üst Limit       :{Int16.MaxValue,20}");
            Console.WriteLine($"    Boyut       :{sizeof(Int16),20}");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"ALT Limit       :{UInt16.MaxValue,20}");
            Console.WriteLine($"Üst Limit       :{UInt16.MaxValue,20}");
            Console.WriteLine($"    Boyut       :{sizeof(UInt16),20}");  //BOYUT
            Console.WriteLine();
            Console.ReadKey();

            //İNT32
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"ALT Limit       :{Int32.MaxValue,20}");
            Console.WriteLine($"Üst Limit       :{Int32.MaxValue,20}");
            Console.WriteLine($"    Boyut       :{sizeof(Int32),20}");
            Console.WriteLine();
            Console.ReadKey();

            //UİNT32
            Console.WriteLine(nameof(UInt32));
            Console.WriteLine($"ALT Limit       :{UInt32.MaxValue,20}");
            Console.WriteLine($"Üst Limit       :{UInt32.MaxValue,20}");
            Console.WriteLine($"    Boyut       :{sizeof(UInt32),20}");  //BOYUT
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
