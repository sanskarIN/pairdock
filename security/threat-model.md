# Threat Model

## Assets

- User accounts and JWTs.
- Device certificates.
- Wi-Fi credentials during provisioning.
- Firmware packages and signing keys.
- Telemetry and command history.

## Threats

- Unauthorized device ownership claims.
- Bluetooth pairing interception.
- Wi-Fi credential leakage.
- Forged firmware packages.
- Replay of device commands.
- API token theft.

## Controls

- Pairing sessions expire quickly.
- Commands require ownership and audit logging.
- Firmware manifests are signed.
- Secrets are never logged.
- Device certificates are rotated through controlled flows.
