using Microsoft.EntityFrameworkCore;
namespace GoodHabits.Database.Entities;
[Index(nameof(Id))]
public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
}
