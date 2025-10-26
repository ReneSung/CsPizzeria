using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PizzeriaWebService.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
{
  public void Configure(EntityTypeBuilder<UserEntity> builder)
  {
    builder.ToTable("users");
    
    builder.HasKey(u => u.Id);
    
    builder.Property(u => u.Id)
      .HasColumnName("id");
    
    builder.Property(u => u.PhoneNumber)
      .HasColumnName("phone_number");

    builder.HasIndex(u => u.PhoneNumber);

    builder.Property(u => u.PasswordHash)
      .HasColumnName("password_hash");
    
    builder.Property(u => u.Salt)
      .HasColumnName("salt");
    
  }
}