#pragma once

#include <cstdint>

namespace scx {

struct SensorSnapshot {
  uint16_t supplyMillivolts;
  int temperatureCelsius;
};

class SensorManager {
public:
  SensorSnapshot sample() const;
};

}
