#pragma once

#include <string>

namespace scx {

class DeviceAuthenticator {
public:
  bool hasProvisionedIdentity() const;
  bool verifyChallenge(const std::string &challenge, const std::string &signature) const;
};

}

