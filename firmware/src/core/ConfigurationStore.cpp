#include "core/ConfigurationStore.hpp"

namespace scx {

bool ConfigurationStore::save(const DeviceConfiguration &configuration) {
  configuration_ = configuration;
  return true;
}

std::optional<DeviceConfiguration> ConfigurationStore::load() const {
  return configuration_;
}

bool ConfigurationStore::clear() {
  configuration_.reset();
  return true;
}

}

