using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediBaseManager krediBaseManager,ILoggerService loggerService)
        {

            krediBaseManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendimesiYap(List<IKrediBaseManager> krediList)
        {

            foreach (var kredi in krediList)
            {
                kredi.Hesapla();
            }
        }
    }
}
