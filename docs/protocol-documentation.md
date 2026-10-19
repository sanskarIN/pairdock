# Protocol Documentation

Protocol contracts live in `shared/protocol`.

## Design Goals

- Versioned messages.
- JSON payloads for cloud and app interoperability.
- Binary packet concept for constrained device links.
- Explicit error codes.
- Safe forward compatibility.

## Message Families

- DeviceCommand
- DeviceStatus
- TelemetryPacket
- PairingRequest
- PairingResponse
- WifiProvisioningRequest
- FirmwareUpdateManifest

SCX-TODO: Add protobuf or MessagePack option in Phase 3 if binary performance requires it.

