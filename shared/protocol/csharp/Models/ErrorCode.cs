namespace SanskarConnectX.Protocol.Models;

public enum ErrorCode
{
    None = 0,
    ValidationFailed = 1000,
    AuthenticationFailed = 1001,
    PairingExpired = 1002,
    WifiConnectionFailed = 1003,
    DeviceNotRegistered = 1004,
    FirmwareSignatureInvalid = 1005,
    CommandUnsupported = 1006,
    InternalError = 1999
}

