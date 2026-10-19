using Microsoft.AspNetCore.Mvc;

namespace SanskarConnectX.Api.Controllers;

[ApiController]
[Route("api/health-info")]
public sealed class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new
    {
        status = "healthy",
        service = "PairDock API",
        credit = "Made by Sanskar"
    });
}

