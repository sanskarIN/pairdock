#pragma once

#include <functional>
#include <string>
#include <vector>

namespace scx {

struct Event {
  std::string name;
  std::string payload;
};

class EventBus {
public:
  using Handler = std::function<void(const Event &)>;

  void subscribe(Handler handler);
  void publish(const Event &event) const;

private:
  std::vector<Handler> handlers_;
};

}
