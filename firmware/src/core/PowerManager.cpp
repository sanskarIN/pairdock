#include "core/PowerManager.hpp"

namespace scx {

void PowerManager::requestLowPowerMode(bool enabled) {
  lowPowerModeEnabled_ = enabled;
}

bool PowerManager::lowPowerModeEnabled() const {
  return lowPowerModeEnabled_;
}

}
