#include "scx_hal_gpio.h"
#include <assert.h>

int main(void) {
  assert(scx_hal_gpio_configure(2, SCX_GPIO_OUTPUT) == SCX_OK);
  assert(scx_hal_gpio_write(2, true) == SCX_OK);
  return 0;
}
