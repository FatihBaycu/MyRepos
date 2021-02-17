using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
           gamerManager.NewGamer(new Gamer()
           {
               adi = "fatih",
               soyadi = "fatih",
               dogumYili = 1999,
               tcNo = "12345678912"
           });

           CampaignManager campaignManager = new CampaignManager();
           campaignManager.Order();
           Console.ReadKey();




        }
    }
}
