#include "connectivity/PairingManager.hpp"
#include "connectivity/WifiManager.hpp"
#include "connectivity/WifiProvisioningService.hpp"
#include "core/ConfigurationStore.hpp"
#include <cassert>

int main() {
  scx::WifiManager wifi;
  scx::PairingManager pairing;
  scx::ConfigurationStore store;
  scx::WifiProvisioningService service(wifi, pairing, store);

  pairing.beginPairing();
  pairing.accept("12345678");

  auto result = service.provision({
    pairing.activeSession().sessionId,
    "LabNetwork",
    "correct-password",
    "https://localhost:7241",
    "SCX-DEVKIT-001"
  });

  assert(result.status == scx::ProvisioningStatus::Accepted);
  assert(store.load().has_value());
  return 0;
}
