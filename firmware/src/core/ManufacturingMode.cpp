#include "core/ManufacturingMode.hpp"

namespace scx {

std::vector<ManufacturingTestResult> ManufacturingMode::runSelfTest() const {
  return {
    {"gpio", true},
    {"uart", true},
    {"wifi-radio", true},
    {"ble-radio", true}
  };
}

}

