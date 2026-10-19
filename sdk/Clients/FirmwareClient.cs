using System.Net.Http.Json;
using SanskarConnectX.Sdk.Logging;
using SanskarConnectX.Sdk.Models;

namespace SanskarConnectX.Sdk.Clients;

public sealed class FirmwareClient
{
    private readonly HttpClient httpClient;
    private readonly ISdkLogger logger;

    public FirmwareClient(HttpClient httpClient, ISdkLogger logger)
    {
        this.httpClient = httpClient;
        this.logger = logger;
    }

    public async Task<SdkResult<IReadOnlyList<FirmwareVersionSummary>>> ListAsync(CancellationToken cancellationToken)
    {
        logger.Info("Loading firmware versions.");
        var versions = await httpClient.GetFromJsonAsync<List<FirmwareVersionSummary>>("/api/firmware", cancellationToken);
        return SdkResult<IReadOnlyList<FirmwareVersionSummary>>.Success(versions ?? new List<FirmwareVersionSummary>());
    }
}

