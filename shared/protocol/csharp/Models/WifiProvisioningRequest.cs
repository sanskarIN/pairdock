namespace SanskarConnectX.Protocol.Models;

public sealed record WifiProvisioningRequest(
    string PairingSessionId,
    string Ssid,
    string Password,
    string ApiBaseUrl);

