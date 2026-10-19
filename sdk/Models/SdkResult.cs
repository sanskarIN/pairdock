namespace SanskarConnectX.Sdk.Models;

public sealed record SdkResult<T>(bool Succeeded, T? Data, string? Error)
{
    public static SdkResult<T> Success(T data) => new(true, data, null);
    public static SdkResult<T> Failure(string error) => new(false, default, error);
}

