# Security Policy

PairDock handles device identity, Wi-Fi provisioning, Bluetooth pairing, telemetry, cloud commands, and OTA updates. Security changes must be reviewed carefully.

## Reporting

Report vulnerabilities privately to the project maintainer. Do not publish exploit details before a fix is available.

## Scope

- Firmware authentication and secure OTA.
- Backend API authentication and authorization.
- Mobile, desktop, and dashboard credential handling.
- Device certificates and API keys.
- Bluetooth and Wi-Fi provisioning flows.

## Baseline Rules

- Never commit secrets.
- Never log Wi-Fi passwords, tokens, private keys, or pairing secrets.
- Prefer short-lived tokens.
- Sign firmware packages.
- Require ownership checks before device commands.

Made by Sanskar.

