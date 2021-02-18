using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Managements;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer();
            gamer1.adi = "Adi";
            gamer1.soyadi = "Soyadi";
            gamer1.dogumYili = 1999;
            gamer1.tcNo = "12345678910";
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);

            Game game1 = new Game();
            game1.adi = "Cyberpunk 2077";
            game1.id = 1;
            game1.price = 270;
            GameManager gameManager = new GameManager();
            gameManager.NewGame(game1);

            Campaign campaign1 = new Campaign();
            campaign1.campaignName = "!!New Gamer!!";
            campaign1.campaignId = 1;
            campaign1.campaignDate = 2021;
            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.NewCampaign(campaign1);

            OrderManager orderManager = new OrderManager();
            orderManager.AddWithCampaign(game1,gamer1,campaign1);


            Console.ReadKey();




        }
    }
}
