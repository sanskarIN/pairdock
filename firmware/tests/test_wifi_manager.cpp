#include "connectivity/WifiManager.hpp"
#include <cassert>

int main() {
  scx::WifiManager wifi;
  assert(wifi.connect("LabNetwork", "correct-password"));
  assert(wifi.state() == scx::WifiConnectionState::Connected);
  wifi.disconnect();
  assert(wifi.state() == scx::WifiConnectionState::Disconnected);
  return 0;
}

