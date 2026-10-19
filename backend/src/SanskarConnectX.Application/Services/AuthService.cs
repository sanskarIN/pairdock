using SanskarConnectX.Application.Abstractions;
using SanskarConnectX.Application.Common;
using SanskarConnectX.Application.DTOs;
using SanskarConnectX.Application.Validation;
using SanskarConnectX.Domain.Entities;
using SanskarConnectX.Domain.Enums;

namespace SanskarConnectX.Application.Services;

public sealed class AuthService : IAuthService
{
    private readonly IUserRepository users;
    private readonly IJwtTokenService tokens;
    private readonly IPasswordHasher passwordHasher;
    private readonly IUnitOfWork unitOfWork;

    public AuthService(IUserRepository users, IJwtTokenService tokens, IPasswordHasher passwordHasher, IUnitOfWork unitOfWork)
    {
        this.users = users;
        this.tokens = tokens;
        this.passwordHasher = passwordHasher;
        this.unitOfWork = unitOfWork;
    }

    public async Task<ApiResult<AuthResponse>> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken)
    {
        if (!RequestValidator.HasEmail(request.Email) || !RequestValidator.HasStrongEnoughPassword(request.Password))
        {
            return ApiResult<AuthResponse>.Failure("validation_failed", "A valid email and password of at least 8 characters are required.");
        }

        var existing = await users.FindByEmailAsync(request.Email, cancellationToken);
        if (existing is not null)
        {
            return ApiResult<AuthResponse>.Failure("email_exists", "An account already exists.");
        }

        var displayName = string.IsNullOrWhiteSpace(request.DisplayName) ? request.Email : request.DisplayName;
        var user = new User(request.Email, displayName, passwordHasher.Hash(request.Password), UserRole.User);
        await users.AddAsync(user, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ApiResult<AuthResponse>.Success(new AuthResponse(tokens.CreateToken(user), user.Email, user.DisplayName, user.Role.ToString()));
    }

    public async Task<ApiResult<AuthResponse>> LoginAsync(LoginRequest request, CancellationToken cancellationToken)
    {
        var user = await users.FindByEmailAsync(request.Email, cancellationToken);
        if (user is null || !passwordHasher.Verify(request.Password, user.PasswordHash))
        {
            return ApiResult<AuthResponse>.Failure("invalid_credentials", "Email or password is incorrect.");
        }

        return ApiResult<AuthResponse>.Success(new AuthResponse(tokens.CreateToken(user), user.Email, user.DisplayName, user.Role.ToString()));
    }
}
