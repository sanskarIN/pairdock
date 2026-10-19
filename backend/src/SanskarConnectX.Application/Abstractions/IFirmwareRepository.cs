using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Application.Abstractions;

public interface IFirmwareRepository
{
    Task<IReadOnlyList<FirmwareVersion>> ListAsync(CancellationToken cancellationToken);
    Task AddAsync(FirmwareVersion version, CancellationToken cancellationToken);
}
