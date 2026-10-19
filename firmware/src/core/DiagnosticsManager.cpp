#include "core/DiagnosticsManager.hpp"

namespace scx {

void DiagnosticsManager::record(const std::string &message) {
  messages_.push_back(message);
}

const std::vector<std::string> &DiagnosticsManager::messages() const {
  return messages_;
}

}

