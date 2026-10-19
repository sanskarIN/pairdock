#include "core/Application.hpp"

int main() {
  scx::Application app;
  return app.boot() ? 0 : 1;
}
