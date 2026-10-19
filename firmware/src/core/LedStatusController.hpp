#pragma once

#include "core/DeviceStateMachine.hpp"

namespace scx {

class LedStatusController {
public:
  void apply(DeviceState state);
  DeviceState lastState() const;

private:
  DeviceState lastState_ = DeviceState::Booting;
};

}

