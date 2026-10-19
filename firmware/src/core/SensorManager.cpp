#include "core/SensorManager.hpp"

namespace scx {

SensorSnapshot SensorManager::sample() const {
  return SensorSnapshot{3300, 27};
}

}

