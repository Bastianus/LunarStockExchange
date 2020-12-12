namespace LunarStockExchange.Models
{
    public class Transfer
    {
        public long Id { get; set; }
        public long CompanyId { get; set; }
        public Company Company { get; set; }
        public long GiverId { get; set; }
        public Dealer Giver { get; set; }
        public long ReceiverId { get; set; }
        public Dealer Receiver { get; set; }
        public long AuctionId { get; set; }
        public Auction Auction { get; set; }
        public int NumberOfStocks { get; set; }
    }
}
