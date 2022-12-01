using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class MarketManager : IMarketService
    {
        public void Add(Market market)
        {
            Console.WriteLine("Items added to your card.");
        }

        public void Delete(Market market)
        {
            Console.WriteLine("Items deleted from your card.");
        }

        public void Update(Market market)
        {
            Console.WriteLine("Your card is updated.");
        }
    }
}
