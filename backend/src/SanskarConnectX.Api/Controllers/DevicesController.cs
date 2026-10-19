using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanskarConnectX.Application.DTOs;
using SanskarConnectX.Application.Services;

namespace SanskarConnectX.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/devices")]
public sealed class DevicesController : ControllerBase
{
    private readonly IDeviceService deviceService;

    public DevicesController(IDeviceService deviceService)
    {
        this.deviceService = deviceService;
    }

    [HttpGet]
    public async Task<IActionResult> List(CancellationToken cancellationToken)
    {
        var result = await deviceService.ListAsync(cancellationToken);
        return Ok(result.Data);
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterDeviceRequest request, CancellationToken cancellationToken)
    {
        var result = await deviceService.RegisterAsync(request, cancellationToken);
        return result.Succeeded ? Ok(result.Data) : BadRequest(result);
    }

    [HttpPost("{deviceId}/commands")]
    public async Task<IActionResult> QueueCommand(string deviceId, CreateDeviceCommandRequest request, CancellationToken cancellationToken)
    {
        var result = await deviceService.QueueCommandAsync(deviceId, request, cancellationToken);
        return result.Succeeded ? Ok(result.Data) : NotFound(result);
    }
}
