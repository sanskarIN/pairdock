#pragma once

#include <string>

namespace scx {

class BleManager {
public:
  void startAdvertising(const std::string &deviceName);
  void stopAdvertising();
  bool isAdvertising() const;
  const std::string &advertisedName() const;

private:
  bool advertising_ = false;
  std::string advertisedName_;
};

}

