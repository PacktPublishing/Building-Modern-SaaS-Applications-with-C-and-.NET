using Microsoft.EntityFrameworkCore;
using GoodHabits.Database.Entities;

namespace GoodHabits.Database;
public class GoodHabitsDbContext : DbContext
{
  private readonly ITenantService _tenantService;

  public GoodHabitsDbContext(DbContextOptions options, ITenantService service) : base(options) => _tenantService = service;

  public string TenantName { get => _tenantService.GetTenant()?.TenantName ?? String.Empty; }

  public DbSet<Habit>? Habits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var tenantConnectionString = _tenantService.GetConnectionString();
        if (!string.IsNullOrEmpty(tenantConnectionString))
        {
            optionsBuilder.UseSqlServer(_tenantService.GetConnectionString());
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.Entity<Habit>().HasQueryFilter(a => a.TenantName == TenantName);
    SeedData.Seed(modelBuilder);
    }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
  {
    ChangeTracker.Entries<IHasTenant>()
        .Where(entry => entry.State == EntityState.Added || entry.State == EntityState.Modified)
        .ToList()
        .ForEach(entry => entry.Entity.TenantName = TenantName);
    return await base.SaveChangesAsync(cancellationToken);
  }
}
