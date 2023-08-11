using Microsoft.EntityFrameworkCore;
using StormShop.API.Models;

namespace StormShop.API.Data
{
    public class AplicationContext : DbContext
    {
        public AplicationContext() { }
        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options)
        {
        }

        DbSet<Product> Products { get; set; }
    }
}
