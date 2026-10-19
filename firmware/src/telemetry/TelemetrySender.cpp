#include "telemetry/TelemetrySender.hpp"

namespace scx {

bool TelemetrySender::enqueue(const TelemetryPacket &packet) {
  pending_.push_back(packet);
  return true;
}

int TelemetrySender::pendingCount() const {
  return static_cast<int>(pending_.size());
}

bool TelemetrySender::flush() {
  pending_.clear();
  return true;
}

}

