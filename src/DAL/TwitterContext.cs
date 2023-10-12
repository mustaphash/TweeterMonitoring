using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class TwitterContext : DbContext
    {
        public TwitterContext()
        {
        }

        public TwitterContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<TwitterAccount> TwitterAccounts { get; set; }
        public DbSet<Tweet> MyProperty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
