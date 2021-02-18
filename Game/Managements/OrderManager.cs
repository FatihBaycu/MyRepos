using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Services;

namespace Game
{
    class OrderManager:IOrderService
    {
        public void AddWithCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.adi + " " + gamer.soyadi + "," + campaign.campaignName + " kampanyasıyla " + game.adi + " oyunu aldı.");
        }

        public void Add(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.adi + " " + gamer.soyadi + " ," + game.adi + " oyunu aldı.");
        }

        public void DeleteWithCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.adi + " " + gamer.soyadi + "," + campaign.campaignName + " kampanyasıyla " + game.adi + " oyunu satışı silindi.");
        }

        public void Delete(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.adi + " " + gamer.soyadi + " ," + game.adi + " oyun satışı silindi.");
        }

        public void UpdateWithCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.adi + " " + gamer.soyadi + "," + campaign.campaignName + " kampanyasıyla " + game.adi + " oyunu satışı güncellendi.");
        }

        public void Update(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.adi + " " + gamer.soyadi + " ," + game.adi + " oyun satışı güncellendi.");
        }
    }
}
