using SanskarConnectX.Sdk.Http;

Console.WriteLine("PairDock SDK Console Example");
Console.WriteLine("Made by Sanskar");

var client = new SanskarConnectXClient(new Uri("https://localhost:7241"));
var result = await client.Devices.ListAsync(CancellationToken.None);
Console.WriteLine($"Device count: {result.Data?.Count ?? 0}");

