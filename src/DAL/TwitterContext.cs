using Core.Entities;
using DAL.Configs;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TwitterAccountConfig());
        }
    }
}
