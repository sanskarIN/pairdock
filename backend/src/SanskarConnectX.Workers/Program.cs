using SanskarConnectX.Workers;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<FirmwareRolloutWorker>();
builder.Services.AddHostedService<TelemetryRetentionWorker>();

var host = builder.Build();
host.Run();
