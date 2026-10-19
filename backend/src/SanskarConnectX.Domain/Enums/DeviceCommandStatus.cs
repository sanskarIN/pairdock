namespace SanskarConnectX.Domain.Enums;

public enum DeviceCommandStatus
{
    Queued = 0,
    Sent = 1,
    Acknowledged = 2,
    Completed = 3,
    Failed = 4,
    Expired = 5
}

