# Encryption

## In Transit

- TLS for backend communication.
- BLE pairing should derive a short-lived encrypted provisioning channel.

## At Rest

- Backend secrets use environment or secret manager.
- Wi-Fi credentials are never stored in app logs.
- Firmware secure storage should use hardware-backed flash encryption where available.
