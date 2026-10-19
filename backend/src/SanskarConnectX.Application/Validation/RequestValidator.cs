namespace SanskarConnectX.Application.Validation;

public static class RequestValidator
{
    public static bool HasEmail(string value) =>
        !string.IsNullOrWhiteSpace(value) && value.Contains('@', StringComparison.Ordinal);

    public static bool HasDeviceId(string value) =>
        !string.IsNullOrWhiteSpace(value) && value.Length <= 64;

    public static bool HasStrongEnoughPassword(string value) =>
        !string.IsNullOrWhiteSpace(value) && value.Length >= 8;

    public static bool HasSerialNumber(string value) =>
        !string.IsNullOrWhiteSpace(value) && value.Length <= 64;

    public static bool HasDisplayName(string value) =>
        !string.IsNullOrWhiteSpace(value) && value.Trim().Length <= 160;

    public static bool IsLikelyJsonObject(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        var trimmed = value.Trim();
        return trimmed.StartsWith("{", StringComparison.Ordinal) && trimmed.EndsWith("}", StringComparison.Ordinal);
    }
}
