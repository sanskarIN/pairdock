using Microsoft.AspNetCore.Mvc;
using SanskarConnectX.Application.DTOs;
using SanskarConnectX.Application.Services;

namespace SanskarConnectX.Api.Controllers;

[ApiController]
[Route("api/telemetry")]
public sealed class TelemetryController : ControllerBase
{
    private readonly ITelemetryService telemetryService;

    public TelemetryController(ITelemetryService telemetryService)
    {
        this.telemetryService = telemetryService;
    }

    [HttpPost("ingest")]
    public async Task<IActionResult> Ingest(TelemetryIngestRequest request, CancellationToken cancellationToken)
    {
        var result = await telemetryService.IngestAsync(request, cancellationToken);
        return result.Succeeded ? Accepted(result.Data) : BadRequest(result);
    }
}

