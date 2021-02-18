using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class CampaignManager:ICampaignSerivce
    {
        public void NewCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.campaignName+" Campaign Created!");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.campaignName + " Campaign Deleted!");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.campaignName + " ampaign Updated!");
        }

    }
}
