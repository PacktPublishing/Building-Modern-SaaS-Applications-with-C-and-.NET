using Microsoft.AspNetCore.Mvc;

namespace GoodHabits.HabitService.Controllers.v2;

[ApiController]
[Route("api/[controller]")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("2.0")]
public class HabitsController : ControllerBase
{
    [MapToApiVersion("2.0")]
    [HttpGet("version")]
    public virtual IActionResult GetVersion()
    {
        return Ok("Response from version 2.0");
    }
}