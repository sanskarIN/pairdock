#include "core/CrashLogger.hpp"

namespace scx {

void CrashLogger::capture(const std::string &reason) {
  lastCrash_ = reason;
}

std::optional<std::string> CrashLogger::lastCrash() const {
  return lastCrash_;
}

void CrashLogger::clear() {
  lastCrash_.reset();
}

}
