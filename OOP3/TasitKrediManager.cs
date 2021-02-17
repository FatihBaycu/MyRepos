using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TasitKrediManager: IKrediBaseManager
    {
        public void Hesapla()
        {
           Console.WriteLine("Taşıt kredisi ödeme planı hesaplanıdı.");
        }

        public void BirseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
