using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediBaseManager
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac kredisi ödeme planı hesaplanıdı.");

        }
    }
}
