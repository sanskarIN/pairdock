#include "core/DeviceStateMachine.hpp"

namespace scx {

DeviceState DeviceStateMachine::state() const {
  return state_;
}

bool DeviceStateMachine::transitionTo(DeviceState next, const std::string &reason) {
  if (!canTransition(next)) {
    lastReason_ = "Rejected transition to " + std::string(deviceStateName(next)) + ": " + reason;
    history_.push_back(std::string(deviceStateName(state_)) + ": " + lastReason_);
    return false;
  }

  state_ = next;
  lastReason_ = reason;
  history_.push_back(std::string(deviceStateName(state_)) + ": " + reason);
  return true;
}

bool DeviceStateMachine::canTransition(DeviceState next) const {
  if (state_ == DeviceState::Fault) {
    return next == DeviceState::Booting || next == DeviceState::Manufacturing;
  }

  switch (state_) {
    case DeviceState::Booting:
      return next == DeviceState::Manufacturing || next == DeviceState::Pairing || next == DeviceState::Connecting || next == DeviceState::Fault;
    case DeviceState::Manufacturing:
      return next == DeviceState::Pairing || next == DeviceState::Fault;
    case DeviceState::Pairing:
      return next == DeviceState::Provisioning || next == DeviceState::Connecting || next == DeviceState::Fault;
    case DeviceState::Provisioning:
      return next == DeviceState::Connecting || next == DeviceState::Pairing || next == DeviceState::Fault;
    case DeviceState::Connecting:
      return next == DeviceState::Online || next == DeviceState::Pairing || next == DeviceState::Fault;
    case DeviceState::Online:
      return next == DeviceState::Updating || next == DeviceState::Pairing || next == DeviceState::Fault;
    case DeviceState::Updating:
      return next == DeviceState::Online || next == DeviceState::Fault;
    case DeviceState::Fault:
      return next == DeviceState::Booting || next == DeviceState::Manufacturing;
  }

  return false;
}

const std::string &DeviceStateMachine::lastReason() const {
  return lastReason_;
}

const std::vector<std::string> &DeviceStateMachine::history() const {
  return history_;
}

const char *deviceStateName(DeviceState state) {
  switch (state) {
    case DeviceState::Booting:
      return "Booting";
    case DeviceState::Manufacturing:
      return "Manufacturing";
    case DeviceState::Pairing:
      return "Pairing";
    case DeviceState::Provisioning:
      return "Provisioning";
    case DeviceState::Connecting:
      return "Connecting";
    case DeviceState::Online:
      return "Online";
    case DeviceState::Updating:
      return "Updating";
    case DeviceState::Fault:
      return "Fault";
  }

  return "Unknown";
}

}
