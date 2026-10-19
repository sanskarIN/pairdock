#include "core/LedStatusController.hpp"

namespace scx {

void LedStatusController::apply(DeviceState state) {
  lastState_ = state;
}

DeviceState LedStatusController::lastState() const {
  return lastState_;
}

}
