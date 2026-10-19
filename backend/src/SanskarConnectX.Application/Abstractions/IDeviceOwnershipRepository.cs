using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Application.Abstractions;

public interface IDeviceOwnershipRepository
{
    Task<bool> ExistsAsync(Guid userId, Guid deviceId, CancellationToken cancellationToken);
    Task AddAsync(DeviceOwnership ownership, CancellationToken cancellationToken);
}
