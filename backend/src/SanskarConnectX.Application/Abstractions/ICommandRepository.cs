using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Application.Abstractions;

public interface ICommandRepository
{
    Task AddAsync(DeviceCommand command, CancellationToken cancellationToken);
    Task<IReadOnlyList<DeviceCommand>> PendingForDeviceAsync(Guid deviceId, CancellationToken cancellationToken);
}

