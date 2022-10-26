using In_MemoryCaching.Models;
using Microsoft.EntityFrameworkCore;

namespace In_MemoryCaching.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
