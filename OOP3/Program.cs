using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            
            
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);
            
            
            
            //BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager,new FileLoggerService());

            
            //basvuruManager.BasvuruYap(konutKrediManager,new DatabaseLoggerService());
       //           ILoggerService databaseLoggerService = new DatabaseLoggerService();



            //List<IKrediBaseManager> krediler = new List<IKrediBaseManager> { ihtiyacKrediManager };
            List<IKrediBaseManager> krediler = new List<IKrediBaseManager> { ihtiyacKrediManager,tasitKrediManager};
//            basvuruManager.KrediOnBilgilendimesiYap(krediler);

            Console.ReadKey();
        }
    }
}
