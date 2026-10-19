# Shared Protocol

PairDock protocol contracts define messages exchanged by devices, apps, backend services, SDKs, simulators, and manufacturing tools.

Made by Sanskar.

## Message Families

- DeviceCommand
- DeviceStatus
- TelemetryPacket
- PairingRequest
- PairingResponse
- WifiProvisioningRequest
- FirmwareUpdateManifest
- Error codes
- Protocol envelope
- Binary packet concept

## Versioning

Every message is wrapped in a protocol envelope:

```json
{
  "protocolVersion": "1.0",
  "messageType": "TelemetryPacket",
  "messageId": "01HXEXAMPLE",
  "timestampUtc": "2026-05-20T00:00:00Z",
  "payload": {}
}
```

SCX-TODO: Add generated code for firmware C structs in Phase 2.
