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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-6149JFK;Initial Catalog=TwitterMonitoring;Integrated Security=True;Pooling=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
