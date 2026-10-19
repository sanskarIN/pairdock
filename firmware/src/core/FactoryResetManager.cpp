#include "core/FactoryResetManager.hpp"

namespace scx {

FactoryResetManager::FactoryResetManager(ConfigurationStore &store) : store_(store) {
}

bool FactoryResetManager::reset() {
  return store_.clear();
}

}
