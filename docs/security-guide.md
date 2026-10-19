# Security Guide

PairDock protects provisioning, identity, commands, telemetry, and OTA.

## Baseline Controls

- JWT auth for user APIs.
- Device authentication with certificates or signed keys.
- Ownership checks before remote commands.
- Bluetooth pairing with short-lived pairing sessions.
- Wi-Fi passwords never logged or persisted in plaintext.
- Firmware packages signed before release.
- Audit logs for privileged actions.

See `security/` for dedicated topic documents.

Made by Sanskar.

