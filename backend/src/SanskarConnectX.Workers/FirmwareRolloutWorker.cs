namespace SanskarConnectX.Workers;

public sealed class FirmwareRolloutWorker : BackgroundService
{
    private readonly ILogger<FirmwareRolloutWorker> logger;

    public FirmwareRolloutWorker(ILogger<FirmwareRolloutWorker> logger)
    {
        this.logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            logger.LogInformation("PairDock firmware rollout worker heartbeat");
            await Task.Delay(TimeSpan.FromMinutes(5), stoppingToken);
        }
    }
}
