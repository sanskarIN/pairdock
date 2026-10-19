using SanskarConnectX.Application.Common;
using SanskarConnectX.Application.DTOs;

namespace SanskarConnectX.Application.Services;

public interface IDeviceService
{
    Task<ApiResult<IReadOnlyList<DeviceDto>>> ListAsync(CancellationToken cancellationToken);
    Task<ApiResult<DeviceDto>> RegisterAsync(RegisterDeviceRequest request, CancellationToken cancellationToken);
    Task<ApiResult<DeviceCommandDto>> QueueCommandAsync(string deviceId, CreateDeviceCommandRequest request, CancellationToken cancellationToken);
}

