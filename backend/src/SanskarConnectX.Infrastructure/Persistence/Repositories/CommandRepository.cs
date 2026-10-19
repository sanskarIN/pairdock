using Microsoft.EntityFrameworkCore;
using SanskarConnectX.Application.Abstractions;
using SanskarConnectX.Domain.Entities;
using SanskarConnectX.Domain.Enums;

namespace SanskarConnectX.Infrastructure.Persistence.Repositories;

public sealed class CommandRepository : ICommandRepository
{
    private readonly SanskarConnectXDbContext dbContext;

    public CommandRepository(SanskarConnectXDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task AddAsync(DeviceCommand command, CancellationToken cancellationToken) =>
        await dbContext.DeviceCommands.AddAsync(command, cancellationToken);

    public async Task<IReadOnlyList<DeviceCommand>> PendingForDeviceAsync(Guid deviceId, CancellationToken cancellationToken) =>
        await dbContext.DeviceCommands
            .Where(x => x.DeviceId == deviceId && x.Status == DeviceCommandStatus.Queued)
            .OrderBy(x => x.CreatedUtc)
            .ToListAsync(cancellationToken);
}

