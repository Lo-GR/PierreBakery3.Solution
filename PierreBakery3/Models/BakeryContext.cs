using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Bakery.Models
{
  public class BakeryContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Flavor> Flavors {get; set;}
    public virtual DbSet<Treat> Treats {get; set;}
    public virtual DbSet<FlavorTreat> FlavorTreat {get; set;}
    public BakeryContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}