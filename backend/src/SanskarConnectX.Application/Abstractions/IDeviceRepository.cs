using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Application.Abstractions;

public interface IDeviceRepository
{
    Task<IReadOnlyList<Device>> ListAsync(CancellationToken cancellationToken);
    Task<Device?> FindByDeviceIdAsync(string deviceId, CancellationToken cancellationToken);
    Task<Device?> FindBySerialNumberAsync(string serialNumber, CancellationToken cancellationToken);
    Task<Device?> FindByIdAsync(Guid id, CancellationToken cancellationToken);
    Task AddAsync(Device device, CancellationToken cancellationToken);
}
