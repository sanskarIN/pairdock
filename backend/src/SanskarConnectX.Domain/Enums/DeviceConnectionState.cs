namespace SanskarConnectX.Domain.Enums;

public enum DeviceConnectionState
{
    Unknown = 0,
    Offline = 1,
    Pairing = 2,
    Provisioning = 3,
    Online = 4,
    Updating = 5,
    Fault = 6
}
