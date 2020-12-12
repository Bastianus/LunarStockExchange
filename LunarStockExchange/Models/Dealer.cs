using System.Collections.Generic;

namespace LunarStockExchange.Models
{
    public class Dealer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Offer> Offers { get; set; }
        public List<Buy> Buys { get; set; }
        public List<Transfer> Receivers { get; set; }
        public List<Transfer> Givers { get; set; }
        public string Password { get; set; }
    }
}
