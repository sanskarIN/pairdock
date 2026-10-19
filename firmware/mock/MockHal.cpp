#include "MockHal.hpp"

namespace scx::mock {

void MockHal::setGpio(int pin, bool value) {
  gpioValues_[pin] = value;
}

bool MockHal::gpio(int pin) const {
  auto found = gpioValues_.find(pin);
  return found != gpioValues_.end() && found->second;
}

}
