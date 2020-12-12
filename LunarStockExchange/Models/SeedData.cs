using LunarStockExchange.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace LunarStockExchange.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                SeedCompanies(context);

                context.SaveChanges();
            }

            void SeedCompanies(ApplicationDbContext context)
            {
                if (context.Companies.Any())
                {
                    return;
                }

                context.Companies.AddRange(
                    new Company
                    {
                        Name = "Evol",
                        TotalNumberOfStocks = 6735174,
                    },

                    new Company
                    {
                        Name = "In-Gentriment",
                        TotalNumberOfStocks = 7426819,
                    },

                    new Company
                    {
                        Name = "Endeavour",
                        TotalNumberOfStocks = 4137916,
                    },

                    new Company
                    {
                        Name = "OCP",
                        TotalNumberOfStocks = 5134952,
                    },

                    new Company
                    {
                        Name = "UCP",
                        TotalNumberOfStocks = 6749157,
                    }

                );
            }            
        }
    }
}
