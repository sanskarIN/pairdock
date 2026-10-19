#include "core/DeviceStateMachine.hpp"
#include <cassert>

int main() {
  scx::DeviceStateMachine machine;
  assert(machine.transitionTo(scx::DeviceState::Pairing, "ready"));
  assert(machine.transitionTo(scx::DeviceState::Provisioning, "paired"));
  assert(machine.transitionTo(scx::DeviceState::Connecting, "credentials saved"));
  assert(machine.transitionTo(scx::DeviceState::Online, "cloud connected"));
  assert(!machine.transitionTo(scx::DeviceState::Manufacturing, "not allowed"));
  assert(machine.state() == scx::DeviceState::Online);
  return 0;
}
