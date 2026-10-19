namespace SanskarConnectX.Desktop.Services;

public sealed class LocalSettingsService
{
    private readonly Dictionary<string, string> values = new();

    public string? Get(string key) => values.TryGetValue(key, out var value) ? value : null;
    public void Set(string key, string value) => values[key] = value;
}
