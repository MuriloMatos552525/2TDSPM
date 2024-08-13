using Microsoft.EntityFrameworkCore;
using _2TDSPM.Models;

namespace _2TDSPM.Database
{
    public class FIAPDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public FIAPDBContext(DbContextOptions<FIAPDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}