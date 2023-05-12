using AutoMapper;
using GoodHabits.HabitService.Dtos;
using GoodHabits.Database.Entities;

namespace GoodHabits.HabitService.Mappers;

public class HabitMapper : Profile
{
    public HabitMapper()
    {
        CreateMap<Habit, HabitDto>();
    }
}
