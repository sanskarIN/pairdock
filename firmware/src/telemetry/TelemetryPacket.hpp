#pragma once

#include <cstdint>
#include <string>

namespace scx {

struct TelemetryPacket {
  std::string deviceId;
  uint64_t timestampMs;
  int rssi;
  int temperatureCelsius;
  uint16_t supplyMillivolts;
  std::string firmwareVersion;
};

std::string toJson(const TelemetryPacket &packet);

}

