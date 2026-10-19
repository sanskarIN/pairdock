# C# SDK

The PairDock SDK provides typed clients for apps, tools, and tests.

Made by Sanskar.

## Clients

- AuthClient
- DeviceClient
- TelemetryClient
- FirmwareClient
- DeviceCommandClient

## Example

```csharp
var sdk = new SanskarConnectXClient(new Uri("https://localhost:7241"), logger);
var devices = await sdk.Devices.ListAsync(CancellationToken.None);
```

SCX-TODO: Generate SDK clients from OpenAPI in Phase 3.
