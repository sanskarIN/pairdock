using SanskarConnectX.Application.Common;
using SanskarConnectX.Application.DTOs;

namespace SanskarConnectX.Application.Services;

public interface ITelemetryService
{
    Task<ApiResult<string>> IngestAsync(TelemetryIngestRequest request, CancellationToken cancellationToken);
}

