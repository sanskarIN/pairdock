using Microsoft.EntityFrameworkCore;
using SanskarConnectX.Application.Abstractions;
using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Infrastructure.Persistence.Repositories;

public sealed class TelemetryRepository : ITelemetryRepository
{
    private readonly SanskarConnectXDbContext dbContext;

    public TelemetryRepository(SanskarConnectXDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task AddAsync(TelemetrySample sample, CancellationToken cancellationToken) =>
        await dbContext.Telemetry.AddAsync(sample, cancellationToken);

    public async Task<IReadOnlyList<TelemetrySample>> LatestForDeviceAsync(Guid deviceId, int take, CancellationToken cancellationToken) =>
        await dbContext.Telemetry
            .Where(x => x.DeviceId == deviceId)
            .OrderByDescending(x => x.TimestampUtc)
            .Take(take)
            .ToListAsync(cancellationToken);
}

