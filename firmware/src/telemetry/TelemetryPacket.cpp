#include "telemetry/TelemetryPacket.hpp"
#include <sstream>

namespace scx {

std::string toJson(const TelemetryPacket &packet) {
  std::ostringstream stream;
  stream << "{"
         << "\"deviceId\":\"" << packet.deviceId << "\","
         << "\"timestampMs\":" << packet.timestampMs << ","
         << "\"rssi\":" << packet.rssi << ","
         << "\"temperatureCelsius\":" << packet.temperatureCelsius << ","
         << "\"supplyMillivolts\":" << packet.supplyMillivolts << ","
         << "\"firmwareVersion\":\"" << packet.firmwareVersion << "\""
         << "}";
  return stream.str();
}

}

