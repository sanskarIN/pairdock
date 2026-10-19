cmake_minimum_required(VERSION 3.24)
project(SanskarConnectXFirmware LANGUAGES C CXX)

set(CMAKE_C_STANDARD 11)
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

add_library(scx_firmware_core STATIC
  hal/src/scx_hal_gpio.c
  hal/src/scx_hal_uart.c
  hal/src/scx_hal_i2c.c
  hal/src/scx_hal_spi.c
  hal/src/scx_hal_adc.c
  hal/src/scx_hal_pwm.c
  hal/src/scx_hal_storage.c
  hal/src/scx_hal_timer.c
  bsp/src/connectx_board.c
  src/core/Application.cpp
  src/core/EventBus.cpp
  src/core/DeviceStateMachine.cpp
  src/core/ConfigurationStore.cpp
  src/core/LedStatusController.cpp
  src/core/ButtonInputController.cpp
  src/core/SensorManager.cpp
  src/core/DiagnosticsManager.cpp
  src/core/CrashLogger.cpp
  src/core/PowerManager.cpp
  src/core/FactoryResetManager.cpp
  src/core/ManufacturingMode.cpp
  src/connectivity/WifiManager.cpp
  src/connectivity/BleManager.cpp
  src/connectivity/PairingManager.cpp
  src/connectivity/WifiProvisioningService.cpp
  src/security/EncryptionHelper.cpp
  src/security/DeviceAuthenticator.cpp
  src/security/SecureBootVerifier.cpp
  src/ota/FirmwareManifest.cpp
  src/ota/OtaUpdater.cpp
  src/telemetry/TelemetryPacket.cpp
  src/telemetry/TelemetrySender.cpp
)

target_include_directories(scx_firmware_core PUBLIC
  include
  hal/include
  bsp/include
  src
)

add_executable(scx_firmware_app src/app/main.cpp)
target_link_libraries(scx_firmware_app PRIVATE scx_firmware_core)

add_executable(scx_test_device_state_machine tests/test_device_state_machine.cpp)
target_link_libraries(scx_test_device_state_machine PRIVATE scx_firmware_core)

add_executable(scx_test_wifi_provisioning tests/test_wifi_provisioning.cpp)
target_link_libraries(scx_test_wifi_provisioning PRIVATE scx_firmware_core)

enable_testing()
add_test(NAME device_state_machine COMMAND scx_test_device_state_machine)
add_test(NAME wifi_provisioning COMMAND scx_test_wifi_provisioning)
