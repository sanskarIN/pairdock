using Microsoft.EntityFrameworkCore;
using SanskarConnectX.Application.Abstractions;
using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Infrastructure.Persistence.Repositories;

public sealed class DeviceOwnershipRepository : IDeviceOwnershipRepository
{
    private readonly SanskarConnectXDbContext dbContext;

    public DeviceOwnershipRepository(SanskarConnectXDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public Task<bool> ExistsAsync(Guid userId, Guid deviceId, CancellationToken cancellationToken) =>
        dbContext.DeviceOwnerships.AnyAsync(x => x.UserId == userId && x.DeviceId == deviceId, cancellationToken);

    public async Task AddAsync(DeviceOwnership ownership, CancellationToken cancellationToken) =>
        await dbContext.DeviceOwnerships.AddAsync(ownership, cancellationToken);
}
