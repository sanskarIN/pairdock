# Firmware Guide

The firmware folder provides an ESP32-style architecture using assembly, C, and C++.

## Layers

- `boot/`: startup and interrupt examples.
- `hal/`: stable C hardware abstraction boundary.
- `drivers/`: low-level drivers that can be swapped for real ESP-IDF implementations.
- `bsp/`: board pin mapping and board bring-up.
- `src/core/`: application runtime, state, event bus, diagnostics, power, factory reset, and manufacturing mode.
- `src/connectivity/`: Wi-Fi, Bluetooth/BLE, provisioning, and pairing.
- `src/security/`: encryption, secure boot, and authentication concepts.
- `src/ota/`: firmware update manifest and update orchestration.
- `src/telemetry/`: telemetry buffering and sending.

## Build

```powershell
cmake -S ./firmware -B ./firmware/build
cmake --build ./firmware/build
```

## Testing

Use host mocks in `firmware/mock/` and test skeletons in `firmware/tests/`.

## Phase 2 Additions

- Device state machine rejects invalid transitions.
- State transition history is available for diagnostics.
- BLE pairing must be accepted before Wi-Fi provisioning.
- Host test targets were added for state machine and provisioning flows.

SCX-TODO: Phase 3 should add ESP-IDF hardware targets and CI execution.
