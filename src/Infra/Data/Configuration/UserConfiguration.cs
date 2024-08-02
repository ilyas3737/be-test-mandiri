using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder){
        builder.ToTable("Users");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nama)
               .IsRequired()
               .HasMaxLength(200);
        
        builder.Property(p => p.RoleName)
                .IsRequired()
                .HasMaxLength(50);
        builder.HasMany(p => p.Message).WithOne(p => p.User).HasForeignKey(p => p.UserId);
        

    }
}
