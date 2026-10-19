using SanskarConnectX.Sdk.Http;

namespace SanskarConnectX.Sdk.Examples;

public static class BasicUsage
{
    public static async Task RunAsync()
    {
        var client = new SanskarConnectXClient(new Uri("https://localhost:7241"));
        var devices = await client.Devices.ListAsync(CancellationToken.None);
        Console.WriteLine($"PairDock devices loaded: {devices.Data?.Count ?? 0}");
    }
}
