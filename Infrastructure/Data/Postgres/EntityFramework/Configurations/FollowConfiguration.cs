using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class FollowConfiguration : IEntityTypeConfiguration<Follow>
    {
        public void Configure(EntityTypeBuilder<Follow> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FollowerUserId).IsRequired();
            builder.Property(x => x.FolloweeUserId).IsRequired();
            builder.Property(x => x.FollowDate).IsRequired();

            //builder.HasOne(f => f.FollowerUser)
            //       .WithMany(u => u.Followers)
            //       .HasForeignKey(f => f.FollowerUserId);

            //builder.HasOne(f => f.FolloweeUser)
            //       .WithMany(u => u.Followings)
            //       .HasForeignKey(f => f.FolloweeUserId);
        }
    }
}
