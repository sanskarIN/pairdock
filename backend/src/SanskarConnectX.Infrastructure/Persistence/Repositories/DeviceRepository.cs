using Microsoft.EntityFrameworkCore;
using SanskarConnectX.Application.Abstractions;
using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Infrastructure.Persistence.Repositories;

public sealed class DeviceRepository : IDeviceRepository
{
    private readonly SanskarConnectXDbContext dbContext;

    public DeviceRepository(SanskarConnectXDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IReadOnlyList<Device>> ListAsync(CancellationToken cancellationToken) =>
        await dbContext.Devices.OrderBy(x => x.DisplayName).ToListAsync(cancellationToken);

    public Task<Device?> FindByDeviceIdAsync(string deviceId, CancellationToken cancellationToken) =>
        dbContext.Devices.FirstOrDefaultAsync(x => x.DeviceId == deviceId, cancellationToken);

    public Task<Device?> FindBySerialNumberAsync(string serialNumber, CancellationToken cancellationToken) =>
        dbContext.Devices.FirstOrDefaultAsync(x => x.SerialNumber == serialNumber, cancellationToken);

    public Task<Device?> FindByIdAsync(Guid id, CancellationToken cancellationToken) =>
        dbContext.Devices.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

    public async Task AddAsync(Device device, CancellationToken cancellationToken) =>
        await dbContext.Devices.AddAsync(device, cancellationToken);
}
