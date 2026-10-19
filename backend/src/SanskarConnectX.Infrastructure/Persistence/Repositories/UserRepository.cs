using Microsoft.EntityFrameworkCore;
using SanskarConnectX.Application.Abstractions;
using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Infrastructure.Persistence.Repositories;

public sealed class UserRepository : IUserRepository
{
    private readonly SanskarConnectXDbContext dbContext;

    public UserRepository(SanskarConnectXDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public Task<User?> FindByEmailAsync(string email, CancellationToken cancellationToken) =>
        dbContext.Users.FirstOrDefaultAsync(x => x.Email == email.Trim().ToLowerInvariant(), cancellationToken);

    public async Task AddAsync(User user, CancellationToken cancellationToken) =>
        await dbContext.Users.AddAsync(user, cancellationToken);
}

