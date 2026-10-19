#pragma once

#include <string>

namespace scx {

class EncryptionHelper {
public:
  std::string maskSecret(const std::string &value) const;
  std::string hashForLog(const std::string &value) const;
};

}
