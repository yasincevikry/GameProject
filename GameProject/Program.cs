using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Yasin";
            gamer1.LastName = "Çevik";
            gamer1.BirthYear = 2001;
            gamer1.Id = 1;
            gamer1.IdentityNumber = 1905;

            Gamer gamer2 = new Gamer();
            gamer2.FirstName = "Edvin";
            gamer2.LastName = "Davulcu";
            gamer2.BirthYear = 2001;
            gamer2.Id = 2;
            gamer2.IdentityNumber = 1903;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Winter";
            campaign1.DiscountRate = 25;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "Summer";
            campaign2.DiscountRate = 20; ;

            Market market1 = new Market();
            market1.ProductID = 1;
            market1.ProductName = "Key";
            market1.Price = 30;
            market1.Price_Summer = 24;
            market1.Price_Winter = 22;

            Market market2 = new Market();
            market2.ProductID = 2;
            market2.ProductName = "Dlc";
            market2.Price = 10;
            market2.Price_Summer = 8;
            market2.Price_Winter = 7;

            GamerManager gamerManager = new GamerManager();
            gamerManager.Register(gamer1);
            gamerManager.Delete(gamer2);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign2);



        }
    }
}
