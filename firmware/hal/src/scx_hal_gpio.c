#include "scx_hal_gpio.h"

scx_error_t scx_hal_gpio_configure(int pin, scx_gpio_direction_t direction) {
  if (pin < 0 || (direction != SCX_GPIO_INPUT && direction != SCX_GPIO_OUTPUT)) {
    return SCX_ERROR_INVALID_ARGUMENT;
  }
  return SCX_OK;
}

scx_error_t scx_hal_gpio_write(int pin, bool value) {
  (void)value;
  return pin >= 0 ? SCX_OK : SCX_ERROR_INVALID_ARGUMENT;
}

scx_error_t scx_hal_gpio_read(int pin, bool *value) {
  if (pin < 0 || value == 0) {
    return SCX_ERROR_INVALID_ARGUMENT;
  }
  *value = false;
  return SCX_OK;
}

