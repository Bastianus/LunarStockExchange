using LunarStockExchange.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LunarStockExchange.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        internal DbSet<Company> Companies { get; set; }
        internal DbSet<Dealer> Dealers { get; set; }
        internal DbSet<Offer> Offers { get; set; }
        internal DbSet<Buy> Buys { get; set; }
        internal DbSet<Auction> Auctions { get; set; }
        internal DbSet<Transfer> Transfers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Company>().Property(c => c.TotalNumberOfStocks).HasColumnName("Total number of stocks");
            modelbuilder.Entity<Offer>().Ignore(o => o.DealerPassword);
            modelbuilder.Entity<Offer>().Property(o => o.MinimumPrice).HasColumnType("decimal(12,2)").IsRequired(false);
            modelbuilder.Entity<Offer>().Property(o => o.DealerPassword).HasMaxLength(32).IsFixedLength(true);
            modelbuilder.Entity<Buy>().Ignore(b => b.DealerPassword);
            modelbuilder.Entity<Buy>().Property(b => b.MaximumPrice).HasColumnType("decimal(12,2)");
            modelbuilder.Entity<Buy>().Property(b => b.DealerPassword).HasMaxLength(32).IsFixedLength(true);
            modelbuilder.Entity<Dealer>().HasMany(t => t.Givers).WithOne(d => d.Giver).OnDelete(DeleteBehavior.Restrict);
            modelbuilder.Entity<Dealer>().HasMany(t => t.Receivers).WithOne(d => d.Receiver).OnDelete(DeleteBehavior.Restrict);
            modelbuilder.Entity<Dealer>().Property(d => d.Password).HasMaxLength(32).IsFixedLength(true);
        }
    }
}
