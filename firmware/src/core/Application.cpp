#include "core/Application.hpp"
#include "connectx_board.h"
#include "scx_version.h"

namespace scx {

bool Application::boot() {
  if (scx_board_init() != SCX_OK || !secureBootVerifier_.verifyBootConfiguration()) {
    stateMachine_.transitionTo(DeviceState::Fault, "Board or secure boot validation failed");
    ledStatusController_.apply(stateMachine_.state());
    return false;
  }

  stateMachine_.transitionTo(DeviceState::Pairing, SCX_FIRMWARE_AUTHOR);
  bleManager_.startAdvertising(SCX_FIRMWARE_NAME);
  pairingManager_.beginPairing();
  pairingManager_.accept("12345678");

  stateMachine_.transitionTo(DeviceState::Provisioning, "BLE pairing accepted");
  const auto provisioning = provisioningService_.provision({
    pairingManager_.activeSession().sessionId,
    "LabNetwork",
    "development-password",
    "https://api.sanskar-connectx.local",
    "SCX-DEVKIT-001"
  });

  if (provisioning.status != ProvisioningStatus::Accepted) {
    stateMachine_.transitionTo(DeviceState::Fault, provisioning.message);
    ledStatusController_.apply(stateMachine_.state());
    return false;
  }

  stateMachine_.transitionTo(DeviceState::Connecting, provisioning.message);
  stateMachine_.transitionTo(DeviceState::Online, "Cloud connection ready");

  TelemetryPacket packet;
  packet.deviceId = "SCX-DEVKIT-001";
  packet.timestampMs = 0;
  packet.rssi = wifiManager_.rssi();
  packet.temperatureCelsius = sensorManager_.sample().temperatureCelsius;
  packet.supplyMillivolts = sensorManager_.sample().supplyMillivolts;
  packet.firmwareVersion = "0.1.0";
  telemetrySender_.enqueue(packet);

  ledStatusController_.apply(stateMachine_.state());
  eventBus_.publish({"system.booted", SCX_FIRMWARE_TAGLINE});
  return true;
}

}
