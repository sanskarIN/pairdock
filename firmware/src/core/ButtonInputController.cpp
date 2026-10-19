#include "core/ButtonInputController.hpp"

namespace scx {

void ButtonInputController::sample(bool pressed) {
  consecutivePressedSamples_ = pressed ? consecutivePressedSamples_ + 1 : 0;
}

bool ButtonInputController::factoryResetRequested() const {
  return consecutivePressedSamples_ >= 5;
}

}
