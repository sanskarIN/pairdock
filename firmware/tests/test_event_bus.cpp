#include "core/EventBus.hpp"
#include <cassert>

int main() {
  scx::EventBus bus;
  bool called = false;

  bus.subscribe([&called](const scx::Event &event) {
    called = event.name == "test.event";
  });

  bus.publish({"test.event", "{}"});
  assert(called);
  return 0;
}

