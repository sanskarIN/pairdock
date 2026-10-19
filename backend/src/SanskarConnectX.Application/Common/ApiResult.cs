namespace SanskarConnectX.Application.Common;

public sealed record ApiResult<T>(bool Succeeded, T? Data, string? ErrorCode, string? Message)
{
    public static ApiResult<T> Success(T data) => new(true, data, null, null);
    public static ApiResult<T> Failure(string errorCode, string message) => new(false, default, errorCode, message);
}
