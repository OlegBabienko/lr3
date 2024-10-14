using lr3.Services;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class TimeController : ControllerBase
{
    private readonly TimeService _timeService;

    public TimeController(TimeService timeService)
    {
        _timeService = timeService;
    }

    [HttpGet]
    public IActionResult GetTimeMessage()
    {
        var message = _timeService.GetTimeOfDayMessage();
        return Ok(message);
    }
}
