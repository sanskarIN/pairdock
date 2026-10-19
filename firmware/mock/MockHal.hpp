#pragma once

#include <map>

namespace scx::mock {

class MockHal {
public:
  void setGpio(int pin, bool value);
  bool gpio(int pin) const;

private:
  std::map<int, bool> gpioValues_;
};

}

