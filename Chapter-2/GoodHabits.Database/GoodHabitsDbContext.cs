using GoodHabits.Database.Entities;
using Microsoft.EntityFrameworkCore;
namespace GoodHabits.Database;
public class GoodHabitsDbContext : DbContext
{
    public DbSet<Habit>? Habits { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlServer("Server=sqlserver;Database=GoodHabitsDatabase;User Id=sa;Password=Password1 ;Integrated Security=false;TrustServerCertificate=true;");
    protected override void OnModelCreating(ModelBuilder modelBuilder) => SeedData.Seed(modelBuilder);
}
