using Moq;
using FluentAssertions;
using GoodHabits.HabitService.Controllers;
using Microsoft.Extensions.Logging;
using GoodHabits.HabitService;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
public class HabitsControllerTests
{
    private readonly HabitsController _habitsController;
    private readonly Mock<ILogger<HabitsController>> _loggerMock;
    private readonly Mock<IHabitService> _habitServiceMock;
    private readonly Mock<IMapper> _mapperMock;

    public HabitsControllerTests()
    {
        _loggerMock = new Mock<ILogger<HabitsController>>();
        _habitServiceMock = new Mock<IHabitService>();
        _mapperMock = new Mock<IMapper>();
        _habitsController = new HabitsController(_loggerMock.Object, _habitServiceMock.Object, _mapperMock.Object);
    }

    [Fact]
    public async Task GetVersion_ReturnsExpectedVersion()
    {
        var result = await _habitsController.GetVersion();
        var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
        okResult.Value.Should().Be("Response from version 1.0");
    }
}
