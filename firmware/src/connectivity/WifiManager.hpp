#pragma once

#include <string>

namespace scx {

enum class WifiConnectionState {
  Disconnected,
  Connecting,
  Connected,
  Failed
};

class WifiManager {
public:
  bool connect(const std::string &ssid, const std::string &password);
  void disconnect();
  WifiConnectionState state() const;
  int rssi() const;

private:
  WifiConnectionState state_ = WifiConnectionState::Disconnected;
  int rssi_ = -127;
};

}

