#include "connectivity/WifiProvisioningService.hpp"

namespace scx {

WifiProvisioningService::WifiProvisioningService(WifiManager &wifi, PairingManager &pairingManager, ConfigurationStore &configurationStore)
  : wifi_(wifi), pairingManager_(pairingManager), configurationStore_(configurationStore) {
}

ProvisioningResult WifiProvisioningService::provision(const WifiProvisioningRequest &request) {
  if (!pairingManager_.verifySession(request.pairingSessionId)) {
    return {ProvisioningStatus::RejectedInvalidPairing, "Pairing session is not active or accepted"};
  }

  if (request.ssid.empty() || request.password.empty() || request.apiBaseUrl.empty() || request.deviceId.empty()) {
    return {ProvisioningStatus::RejectedInvalidCredentials, "Provisioning payload is incomplete"};
  }

  if (!wifi_.connect(request.ssid, request.password)) {
    return {ProvisioningStatus::WifiConnectionFailed, "Wi-Fi connection failed"};
  }

  DeviceConfiguration configuration;
  configuration.wifiSsid = request.ssid;
  configuration.apiBaseUrl = request.apiBaseUrl;
  configuration.deviceId = request.deviceId;

  if (!configurationStore_.save(configuration)) {
    return {ProvisioningStatus::RejectedInvalidCredentials, "Configuration could not be saved"};
  }

  pairingManager_.complete();
  return {ProvisioningStatus::Accepted, "Wi-Fi provisioning accepted"};
}

}
