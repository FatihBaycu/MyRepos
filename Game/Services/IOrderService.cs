using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services
{
    interface IOrderService

    {
        void AddWithCampaign(Game game, Gamer gamer, Campaign campaign);
        void Add(Game game, Gamer gamer);
        
        void DeleteWithCampaign(Game game, Gamer gamer, Campaign campaign);
        void Delete(Game game, Gamer gamer);
        
        void UpdateWithCampaign(Game game, Gamer gamer, Campaign campaign);
        void Update(Game game, Gamer gamer);
        
    }
}
