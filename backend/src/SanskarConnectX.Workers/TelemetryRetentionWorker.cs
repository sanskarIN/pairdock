namespace SanskarConnectX.Workers;

public sealed class TelemetryRetentionWorker : BackgroundService
{
    private readonly ILogger<TelemetryRetentionWorker> logger;

    public TelemetryRetentionWorker(ILogger<TelemetryRetentionWorker> logger)
    {
        this.logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            logger.LogInformation("Telemetry retention policy check is pending Phase 2 implementation");
            await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
        }
    }
}
