#pragma once

#include <optional>
#include <string>

namespace scx {

struct PairingSession {
  std::string sessionId;
  std::string code;
  bool accepted;
};

class PairingManager {
public:
  std::string beginPairing();
  PairingSession activeSession() const;
  bool verifyCode(const std::string &code) const;
  bool accept(const std::string &code);
  bool verifySession(const std::string &sessionId) const;
  void complete();
  bool active() const;

private:
  std::optional<PairingSession> activeSession_;
};

}
