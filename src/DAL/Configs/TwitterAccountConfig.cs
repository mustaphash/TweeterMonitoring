using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class TwitterAccountConfig : IEntityTypeConfiguration<TwitterAccount>
    {
        public void Configure(EntityTypeBuilder<TwitterAccount> builder)
        {
            builder.HasKey(x => x.TweetId);

            builder.Property(x => x.UserName)
                .IsRequired();

            builder.Property(x => x.Url)
                .IsRequired();

            builder.Property(x => x.TweetDate)
                .IsRequired();
        }
    }
}
