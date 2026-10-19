#pragma once

#include <string>
#include "connectivity/PairingManager.hpp"
#include "connectivity/WifiManager.hpp"
#include "core/ConfigurationStore.hpp"

namespace scx {

struct WifiProvisioningRequest {
  std::string pairingSessionId;
  std::string ssid;
  std::string password;
  std::string apiBaseUrl;
  std::string deviceId;
};

enum class ProvisioningStatus {
  Accepted,
  RejectedInvalidPairing,
  RejectedInvalidCredentials,
  WifiConnectionFailed
};

struct ProvisioningResult {
  ProvisioningStatus status;
  std::string message;
};

class WifiProvisioningService {
public:
  WifiProvisioningService(WifiManager &wifi, PairingManager &pairingManager, ConfigurationStore &configurationStore);
  ProvisioningResult provision(const WifiProvisioningRequest &request);

private:
  WifiManager &wifi_;
  PairingManager &pairingManager_;
  ConfigurationStore &configurationStore_;
};

}
