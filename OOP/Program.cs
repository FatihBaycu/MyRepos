using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.adi = "fatih";
            musteri1.soyadi = "fatih2";
            musteri1.id = 1;
            musteri1.musteriNo = "f1";
            musteri1.tcNO = "12345678912";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.sirketAdi = "Kodlama.io";
            musteri2.vergiNo = "VAS692A3D";
            musteri2.musteriNo = "K2";
            musteri2.id = 2;


            Musteri musteri3 = new GercekMusteri();
            Musteri Musteri4 = new TuzelMusteri();



            musteri3.id = 1;
            musteri3.musteriNo = "123";
       
            Console.ReadKey();
        }
    }
}
