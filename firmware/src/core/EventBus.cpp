#include "core/EventBus.hpp"

namespace scx {

void EventBus::subscribe(Handler handler) {
  handlers_.push_back(handler);
}

void EventBus::publish(const Event &event) const {
  for (const auto &handler : handlers_) {
    handler(event);
  }
}

}
