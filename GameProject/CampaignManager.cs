using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Added the new" + campaign.CampaignName +"camapaign.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "campaign updated.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "campaign deleted.");
        }
    }
}
