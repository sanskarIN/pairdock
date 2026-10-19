#include "ota/OtaUpdater.hpp"

namespace scx {

bool OtaUpdater::start(const FirmwareManifest &manifest) {
  if (manifest.packageUrl.empty() || manifest.signature.empty()) {
    state_ = OtaUpdateState::Failed;
    return false;
  }

  state_ = OtaUpdateState::Complete;
  return true;
}

OtaUpdateState OtaUpdater::state() const {
  return state_;
}

}

