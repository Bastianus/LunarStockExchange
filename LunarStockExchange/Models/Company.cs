using System.Collections.Generic;

namespace LunarStockExchange.Models
{
    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Offer> Offers { get; set; }
        public List<Buy> Buys { get; set; }
        public List<Transfer> Transfers { get; set; }
        public long TotalNumberOfStocks { get; set; }
    }
}
