#pragma once

#include <string>
#include <vector>

namespace scx {

enum class DeviceState {
  Booting,
  Manufacturing,
  Pairing,
  Provisioning,
  Connecting,
  Online,
  Updating,
  Fault
};

class DeviceStateMachine {
public:
  DeviceState state() const;
  bool transitionTo(DeviceState next, const std::string &reason);
  bool canTransition(DeviceState next) const;
  const std::string &lastReason() const;
  const std::vector<std::string> &history() const;

private:
  DeviceState state_ = DeviceState::Booting;
  std::string lastReason_ = "Power on";
  std::vector<std::string> history_ = {"Booting: Power on"};
};

const char *deviceStateName(DeviceState state);

}
