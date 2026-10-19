#pragma once

#include <optional>
#include <string>

namespace scx {

class CrashLogger {
public:
  void capture(const std::string &reason);
  std::optional<std::string> lastCrash() const;
  void clear();

private:
  std::optional<std::string> lastCrash_;
};

}

