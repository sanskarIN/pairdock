#include "connectivity/BleManager.hpp"

namespace scx {

void BleManager::startAdvertising(const std::string &deviceName) {
  advertisedName_ = deviceName;
  advertising_ = true;
}

void BleManager::stopAdvertising() {
  advertising_ = false;
}

bool BleManager::isAdvertising() const {
  return advertising_;
}

const std::string &BleManager::advertisedName() const {
  return advertisedName_;
}

}
