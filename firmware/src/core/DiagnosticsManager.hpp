#pragma once

#include <string>
#include <vector>

namespace scx {

class DiagnosticsManager {
public:
  void record(const std::string &message);
  const std::vector<std::string> &messages() const;

private:
  std::vector<std::string> messages_;
};

}
