using Microsoft.EntityFrameworkCore;
using SanskarConnectX.Application.Abstractions;
using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Infrastructure.Persistence.Repositories;

public sealed class FirmwareRepository : IFirmwareRepository
{
    private readonly SanskarConnectXDbContext dbContext;

    public FirmwareRepository(SanskarConnectXDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IReadOnlyList<FirmwareVersion>> ListAsync(CancellationToken cancellationToken) =>
        await dbContext.FirmwareVersions.OrderByDescending(x => x.CreatedUtc).ToListAsync(cancellationToken);

    public async Task AddAsync(FirmwareVersion version, CancellationToken cancellationToken) =>
        await dbContext.FirmwareVersions.AddAsync(version, cancellationToken);
}
