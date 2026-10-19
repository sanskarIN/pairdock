#pragma once

namespace scx {

class ButtonInputController {
public:
  void sample(bool pressed);
  bool factoryResetRequested() const;

private:
  int consecutivePressedSamples_ = 0;
};

}
