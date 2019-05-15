using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.DbMapping
{
    public class UserLogInConfiguration : IEntityTypeConfiguration<UserLogIn>
    {
        public void Configure(EntityTypeBuilder<UserLogIn> builder)
        {
            builder.Property(s => s.UserId).IsRequired();
            builder.Property(s => s.Password).HasColumnType("Password").IsRequired();
        }
    }

}
