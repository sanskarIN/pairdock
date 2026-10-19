#include "security/DeviceAuthenticator.hpp"

namespace scx {

bool DeviceAuthenticator::hasProvisionedIdentity() const {
  return true;
}

bool DeviceAuthenticator::verifyChallenge(const std::string &challenge, const std::string &signature) const {
  return !challenge.empty() && !signature.empty();
}

}
