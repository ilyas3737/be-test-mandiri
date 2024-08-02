using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder){
        builder.ToTable("Messages");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.UserId)
                .HasColumnType("uniqueidentifier");
        builder.Property(p => p.Content)
                .HasColumnType("text");
        builder.Property(p => p.ReadStatus)
                .HasColumnType("bit");
        builder.Property(p => p.CreatedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETUTCDATE()");
        
        builder.HasOne(p => p.User).WithMany(p => p.Message).HasForeignKey(p => p.UserId);
        
    }
}
