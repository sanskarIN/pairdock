#pragma once

#include <string>

namespace scx {

struct FirmwareManifest {
  std::string version;
  std::string hardwareRevision;
  std::string packageUrl;
  std::string sha256;
  std::string signature;
};

bool isManifestCompatible(const FirmwareManifest &manifest, const std::string &hardwareRevision);

}
