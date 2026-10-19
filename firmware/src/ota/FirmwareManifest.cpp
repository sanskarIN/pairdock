#include "ota/FirmwareManifest.hpp"

namespace scx {

bool isManifestCompatible(const FirmwareManifest &manifest, const std::string &hardwareRevision) {
  return !manifest.version.empty() && manifest.hardwareRevision == hardwareRevision && !manifest.sha256.empty();
}

}
