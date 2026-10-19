#include "security/EncryptionHelper.hpp"
#include <functional>

namespace scx {

std::string EncryptionHelper::maskSecret(const std::string &value) const {
  if (value.empty()) {
    return "";
  }
  return "***";
}

std::string EncryptionHelper::hashForLog(const std::string &value) const {
  return std::to_string(std::hash<std::string>{}(value));
}

}

