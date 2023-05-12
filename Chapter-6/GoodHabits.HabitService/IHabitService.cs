using GoodHabits.Database.Entities;
using GoodHabits.HabitService.Dtos;

namespace GoodHabits.HabitService;
public interface IHabitService
{
    Task<Habit> Create(string name, string description);
    Task<Habit> GetById(int id);
    Task<IReadOnlyList<Habit>> GetAll();
    Task DeleteById(int id);
    Task<Habit?> UpdateById(int id, UpdateHabitDto request);
}