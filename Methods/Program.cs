using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.id = 1;
            product1.urunAdi = "Elma";
            product1.aciklama = "Starking Elması";
            product1.fiyat=6.95;
            product1.stokAdedi = 1;

            Product product2 = new Product();
            product2.id = 2;
            product2.urunAdi = "Armut";
            product2.aciklama = "Ankara Armuut";
            product2.fiyat = 7.95;
            product2.stokAdedi = 2;
            
            Product product3 = new Product();
            product3.id = 3;
            product3.urunAdi = "Armut";
            product3.aciklama = "Ankara Armuut";
            product3.fiyat = 7.95;
            product3.stokAdedi = 3;

            Product[] products = new Product[]{product1,product2,product3 };
            
            
            foreach (var product in products)
            {
                Console.WriteLine("Urun ID: "+product.id);
                Console.WriteLine("Urun ADI: " + product.urunAdi);
                Console.WriteLine("Urun ACIKLAMASI: " + product.aciklama);
                Console.WriteLine("Urun FIYATI: " + product.fiyat);
                Console.WriteLine("Urun STOK: " + product.stokAdedi);
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("-------------METOTLAR-----------------");
            
            //instance class örneği
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product3);

            Console.WriteLine("---------------------");

            sepetManager.Ekle2("a", "b", 1, 1);
            sepetManager.Ekle2("c", "d", 1, 1);
            sepetManager.Ekle2("e", "f", 1, 1);
      
            Console.ReadKey();
        }
    }
}
