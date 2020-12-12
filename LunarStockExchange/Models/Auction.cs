using System;
using System.Collections.Generic;

namespace LunarStockExchange.Models
{
    public class Auction
    {
        public long Id { get; set; }
        public DateTime DateAndTime { get; set; }
        public List<Transfer> Transfers { get; set; }
    }
}
