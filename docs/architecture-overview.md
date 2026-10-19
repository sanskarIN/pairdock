# Architecture Overview

PairDock is split into device, cloud, application, manufacturing, and operations planes.

## Device Plane

The firmware runs an ESP32-style architecture:

- Boot assembly examples.
- C HAL and low-level drivers.
- C++ application managers.
- Event bus and device state machine.
- Wi-Fi and BLE provisioning.
- OTA, telemetry, diagnostics, and secure storage concepts.

## Cloud Plane

The backend uses Clean Architecture:

- Domain entities represent users, devices, ownership, telemetry, commands, firmware versions, audit logs, notifications, API keys, and certificates.
- Application services own use cases.
- Infrastructure owns persistence, JWTs, external gateways, and repositories.
- API exposes REST endpoints and middleware.
- Workers handle long-running background processing.

## Application Plane

Desktop, mobile, and web dashboard apps share protocol contracts and SDK clients:

- Desktop app: MVVM device operations console.
- Mobile app: provisioning-first companion app.
- Web dashboard: fleet and admin portal.

## Operations Plane

DevOps, monitoring, security, manufacturing, and tests provide the controls needed to operate the platform professionally.

## Expansion Guidance

SCX-TODO: Add a C4 container diagram and deployment topology diagram in Phase 2.
