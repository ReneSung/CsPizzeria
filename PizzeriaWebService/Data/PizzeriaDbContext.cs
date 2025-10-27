using Microsoft.EntityFrameworkCore;
using PizzeriaWebService.Data.Configurations;

namespace PizzeriaWebService.Data;

public class PizzeriaDbContext : DbContext
{
  public DbSet<UserEntity> Users { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfiguration(new UserConfiguration());
  }
  
  public PizzeriaDbContext(DbContextOptions<PizzeriaDbContext> options)
    :base(options) {}
}