#pragma once

namespace scx {

class PowerManager {
public:
  void requestLowPowerMode(bool enabled);
  bool lowPowerModeEnabled() const;

private:
  bool lowPowerModeEnabled_ = false;
};

}

