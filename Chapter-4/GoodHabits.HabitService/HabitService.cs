using GoodHabits.Database;
using GoodHabits.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoodHabits.HabitService;

public class HabitService : IHabitService
{
    private readonly GoodHabitsDbContext _dbContext;
    public HabitService(GoodHabitsDbContext dbContext) => _dbContext = dbContext;
    public async Task<Habit> Create(string name, string description)
    {
        var habit = _dbContext.Habits!.Add(new Habit { Name = name, Description = description }).Entity;
        await _dbContext.SaveChangesAsync();
        return habit;
    }

    public async Task<IReadOnlyList<Habit>> GetAll() => await _dbContext.Habits!.ToListAsync();

    public async Task<Habit> GetById(int id) =>   await _dbContext.Habits.FindAsync(id);

}
