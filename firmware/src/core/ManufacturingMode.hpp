#pragma once

#include <string>
#include <vector>

namespace scx {

struct ManufacturingTestResult {
  std::string name;
  bool passed;
};

class ManufacturingMode {
public:
  std::vector<ManufacturingTestResult> runSelfTest() const;
};

}
