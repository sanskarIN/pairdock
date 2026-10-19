using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Application.Abstractions;

public interface IJwtTokenService
{
    string CreateToken(User user);
}
