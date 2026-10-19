#pragma once

#include "ota/FirmwareManifest.hpp"

namespace scx {

enum class OtaUpdateState {
  Idle,
  Downloading,
  Verifying,
  Installing,
  Complete,
  Failed
};

class OtaUpdater {
public:
  bool start(const FirmwareManifest &manifest);
  OtaUpdateState state() const;

private:
  OtaUpdateState state_ = OtaUpdateState::Idle;
};

}
