#include "connectivity/PairingManager.hpp"

namespace scx {

std::string PairingManager::beginPairing() {
  activeSession_ = PairingSession{"SCX-PAIR-SESSION-001", "12345678", false};
  return activeSession_->code;
}

PairingSession PairingManager::activeSession() const {
  return activeSession_.value_or(PairingSession{"", "", false});
}

bool PairingManager::verifyCode(const std::string &code) const {
  return activeSession_.has_value() && code == activeSession_->code;
}

bool PairingManager::accept(const std::string &code) {
  if (!verifyCode(code)) {
    return false;
  }

  activeSession_->accepted = true;
  return true;
}

bool PairingManager::verifySession(const std::string &sessionId) const {
  return activeSession_.has_value() && activeSession_->accepted && activeSession_->sessionId == sessionId;
}

void PairingManager::complete() {
  activeSession_.reset();
}

bool PairingManager::active() const {
  return activeSession_.has_value();
}

}
