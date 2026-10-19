#pragma once

#include <vector>
#include "telemetry/TelemetryPacket.hpp"

namespace scx {

class TelemetrySender {
public:
  bool enqueue(const TelemetryPacket &packet);
  int pendingCount() const;
  bool flush();

private:
  std::vector<TelemetryPacket> pending_;
};

}

