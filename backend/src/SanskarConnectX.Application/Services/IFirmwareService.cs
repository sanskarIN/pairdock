using SanskarConnectX.Application.Common;
using SanskarConnectX.Application.DTOs;

namespace SanskarConnectX.Application.Services;

public interface IFirmwareService
{
    Task<ApiResult<IReadOnlyList<FirmwareVersionDto>>> ListAsync(CancellationToken cancellationToken);
    Task<ApiResult<FirmwareVersionDto>> CreateAsync(CreateFirmwareVersionRequest request, CancellationToken cancellationToken);
}
