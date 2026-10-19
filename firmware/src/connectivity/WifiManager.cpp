#include "connectivity/WifiManager.hpp"

namespace scx {

bool WifiManager::connect(const std::string &ssid, const std::string &password) {
  if (ssid.empty() || password.empty()) {
    state_ = WifiConnectionState::Failed;
    return false;
  }

  state_ = WifiConnectionState::Connected;
  rssi_ = -48;
  return true;
}

void WifiManager::disconnect() {
  state_ = WifiConnectionState::Disconnected;
  rssi_ = -127;
}

WifiConnectionState WifiManager::state() const {
  return state_;
}

int WifiManager::rssi() const {
  return rssi_;
}

}
