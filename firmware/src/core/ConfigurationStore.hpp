#pragma once

#include <optional>
#include <string>

namespace scx {

struct DeviceConfiguration {
  std::string deviceId;
  std::string apiBaseUrl;
  std::string wifiSsid;
};

class ConfigurationStore {
public:
  bool save(const DeviceConfiguration &configuration);
  std::optional<DeviceConfiguration> load() const;
  bool clear();

private:
  std::optional<DeviceConfiguration> configuration_;
};

}
