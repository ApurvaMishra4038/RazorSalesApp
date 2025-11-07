using Microsoft.EntityFrameworkCore;
using RazorSalesApp.Model;

namespace RazorSalesApp.Context
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options)
        {

        }
        public DbSet<Sales> Sales { get; set; }
    }
}
