#pragma once

#include "connectivity/BleManager.hpp"
#include "connectivity/PairingManager.hpp"
#include "connectivity/WifiManager.hpp"
#include "connectivity/WifiProvisioningService.hpp"
#include "core/ConfigurationStore.hpp"
#include "core/DeviceStateMachine.hpp"
#include "core/EventBus.hpp"
#include "core/LedStatusController.hpp"
#include "core/SensorManager.hpp"
#include "security/SecureBootVerifier.hpp"
#include "telemetry/TelemetrySender.hpp"

namespace scx {

class Application {
public:
  bool boot();

private:
  EventBus eventBus_;
  DeviceStateMachine stateMachine_;
  ConfigurationStore configurationStore_;
  WifiManager wifiManager_;
  BleManager bleManager_;
  PairingManager pairingManager_;
  WifiProvisioningService provisioningService_{wifiManager_, pairingManager_, configurationStore_};
  LedStatusController ledStatusController_;
  SensorManager sensorManager_;
  SecureBootVerifier secureBootVerifier_;
  TelemetrySender telemetrySender_;
};

}
