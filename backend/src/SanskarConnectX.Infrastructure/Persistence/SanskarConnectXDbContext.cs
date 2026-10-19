using Microsoft.EntityFrameworkCore;
using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Infrastructure.Persistence;

public sealed class SanskarConnectXDbContext : DbContext
{
    public SanskarConnectXDbContext(DbContextOptions<SanskarConnectXDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Device> Devices => Set<Device>();
    public DbSet<DeviceOwnership> DeviceOwnerships => Set<DeviceOwnership>();
    public DbSet<TelemetrySample> Telemetry => Set<TelemetrySample>();
    public DbSet<FirmwareVersion> FirmwareVersions => Set<FirmwareVersion>();
    public DbSet<DeviceCommand> DeviceCommands => Set<DeviceCommand>();
    public DbSet<AuditLog> AuditLogs => Set<AuditLog>();
    public DbSet<Notification> Notifications => Set<Notification>();
    public DbSet<ApiKey> ApiKeys => Set<ApiKey>();
    public DbSet<DeviceCertificate> DeviceCertificates => Set<DeviceCertificate>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SanskarConnectXDbContext).Assembly);
    }
}
