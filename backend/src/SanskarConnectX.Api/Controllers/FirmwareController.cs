using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanskarConnectX.Application.DTOs;
using SanskarConnectX.Application.Services;

namespace SanskarConnectX.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/firmware")]
public sealed class FirmwareController : ControllerBase
{
    private readonly IFirmwareService firmwareService;

    public FirmwareController(IFirmwareService firmwareService)
    {
        this.firmwareService = firmwareService;
    }

    [HttpGet]
    public async Task<IActionResult> List(CancellationToken cancellationToken)
    {
        var result = await firmwareService.ListAsync(cancellationToken);
        return Ok(result.Data);
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Create(CreateFirmwareVersionRequest request, CancellationToken cancellationToken)
    {
        var result = await firmwareService.CreateAsync(request, cancellationToken);
        return result.Succeeded ? Ok(result.Data) : BadRequest(result);
    }
}

