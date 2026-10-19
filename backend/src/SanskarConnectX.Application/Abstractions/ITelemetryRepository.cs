using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Application.Abstractions;

public interface ITelemetryRepository
{
    Task AddAsync(TelemetrySample sample, CancellationToken cancellationToken);
    Task<IReadOnlyList<TelemetrySample>> LatestForDeviceAsync(Guid deviceId, int take, CancellationToken cancellationToken);
}

