using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {

        public void Ekle(Product product)
        {

            Console.WriteLine("Sepete Eklendi. " + product.urunAdi);
            Console.WriteLine("Sepet Tutari: " + product.fiyat);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete eklendi: " + urunAdi);
        }

    }
}
