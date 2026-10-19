#ifndef SCX_HAL_GPIO_H
#define SCX_HAL_GPIO_H

#include <stdbool.h>
#include "scx_error.h"

#ifdef __cplusplus
extern "C" {
#endif

typedef enum scx_gpio_direction_t {
  SCX_GPIO_INPUT = 0,
  SCX_GPIO_OUTPUT = 1
} scx_gpio_direction_t;

scx_error_t scx_hal_gpio_configure(int pin, scx_gpio_direction_t direction);
scx_error_t scx_hal_gpio_write(int pin, bool value);
scx_error_t scx_hal_gpio_read(int pin, bool *value);

#ifdef __cplusplus
}
#endif

#endif

