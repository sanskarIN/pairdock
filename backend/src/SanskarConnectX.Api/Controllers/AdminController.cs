using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SanskarConnectX.Api.Controllers;

[ApiController]
[Authorize(Roles = "Admin")]
[Route("api/admin")]
public sealed class AdminController : ControllerBase
{
    [HttpGet("summary")]
    public IActionResult Summary()
    {
        return Ok(new
        {
            product = "PairDock",
            tagline = "Pair, provision, monitor, and update Wi-Fi and Bluetooth devices.",
            credit = "Made by Sanskar",
            phase = "Phase 1"
        });
    }
}

