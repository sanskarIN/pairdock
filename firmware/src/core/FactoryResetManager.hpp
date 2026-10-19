#pragma once

#include "core/ConfigurationStore.hpp"

namespace scx {

class FactoryResetManager {
public:
  explicit FactoryResetManager(ConfigurationStore &store);
  bool reset();

private:
  ConfigurationStore &store_;
};

}

