using Microsoft.EntityFrameworkCore;
using WebApiAPM.Entities;

namespace WebApiAPM
{
    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Product> Products { get; set; }
    }
}
