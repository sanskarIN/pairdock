using SanskarConnectX.Application.Abstractions;

namespace SanskarConnectX.Infrastructure.Persistence;

public sealed class EfUnitOfWork : IUnitOfWork
{
    private readonly SanskarConnectXDbContext dbContext;

    public EfUnitOfWork(SanskarConnectXDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken) =>
        dbContext.SaveChangesAsync(cancellationToken);
}
