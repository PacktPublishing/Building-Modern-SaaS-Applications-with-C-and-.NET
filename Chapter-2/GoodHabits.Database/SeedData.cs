using GoodHabits.Database.Entities;
using Microsoft.EntityFrameworkCore;

public static class SeedData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Habit>().HasData(
            new Habit { Id = 100, Name = "Learn French", Description = "Become a francophone" },
            new Habit { Id = 101, Name = "Run a marathon", Description = "Get really fit" },
            new Habit { Id = 102, Name = "Write every day", Description = "Finish your book project"  }
        );
    }
}
