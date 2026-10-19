using SanskarConnectX.Sdk.Clients;
using SanskarConnectX.Sdk.Logging;
using System.Net.Http.Headers;

namespace SanskarConnectX.Sdk.Http;

public sealed class SanskarConnectXClient
{
    public SanskarConnectXClient(Uri baseAddress, ISdkLogger? logger = null)
        : this(new SanskarConnectXClientOptions { BaseAddress = baseAddress }, logger)
    {
    }

    public SanskarConnectXClient(SanskarConnectXClientOptions options, ISdkLogger? logger = null)
    {
        var httpClient = new HttpClient
        {
            BaseAddress = options.BaseAddress,
            Timeout = options.Timeout
        };

        if (!string.IsNullOrWhiteSpace(options.AccessToken))
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", options.AccessToken);
        }

        var sdkLogger = logger ?? new NullSdkLogger();

        Auth = new AuthClient(httpClient, sdkLogger);
        Devices = new DeviceClient(httpClient, sdkLogger);
        Telemetry = new TelemetryClient(httpClient, sdkLogger);
        Firmware = new FirmwareClient(httpClient, sdkLogger);
        Commands = new DeviceCommandClient(httpClient, sdkLogger);
    }

    public AuthClient Auth { get; }
    public DeviceClient Devices { get; }
    public TelemetryClient Telemetry { get; }
    public FirmwareClient Firmware { get; }
    public DeviceCommandClient Commands { get; }
}
