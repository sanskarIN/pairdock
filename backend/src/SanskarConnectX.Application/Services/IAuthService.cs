using SanskarConnectX.Application.Common;
using SanskarConnectX.Application.DTOs;

namespace SanskarConnectX.Application.Services;

public interface IAuthService
{
    Task<ApiResult<AuthResponse>> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken);
    Task<ApiResult<AuthResponse>> LoginAsync(LoginRequest request, CancellationToken cancellationToken);
}

