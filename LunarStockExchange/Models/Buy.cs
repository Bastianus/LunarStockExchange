namespace LunarStockExchange.Models
{
    public class Buy
    {
        public long Id { get; set; }
        public long CompanyId { get; set; }
        public Company Company { get; set; }
        public long DealerId { get; set; }
        public Dealer Dealer { get; set; }
        public decimal MaximumPrice { get; set; }
        public string DealerPassword { get; set; }
    }
}
