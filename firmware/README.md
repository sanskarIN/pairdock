# Firmware

ESP32-style firmware foundation for PairDock.

Made by Sanskar.

## Language Split

- Assembly: startup, interrupt vector, and context switch examples.
- C: HAL, low-level drivers, board support package.
- C++: Wi-Fi, BLE, provisioning, OTA, telemetry, security, diagnostics, and device logic.

## Main Modules

- `boot/`: low-level startup examples.
- `include/`: global firmware constants and error codes.
- `hal/`: C hardware abstraction layer.
- `bsp/`: board support package.
- `src/core/`: application runtime and device state.
- `src/connectivity/`: Wi-Fi and Bluetooth/BLE flows.
- `src/security/`: authentication, encryption, secure boot concepts.
- `src/ota/`: OTA update workflow.
- `src/telemetry/`: telemetry packet and sender.
- `mock/`: host mocks for tests.
- `tests/`: unit test skeletons.

## Build

```powershell
cmake -S . -B build
cmake --build build
```

SCX-TODO: Replace host-safe placeholder HAL bodies with ESP-IDF implementations in Phase 2.

