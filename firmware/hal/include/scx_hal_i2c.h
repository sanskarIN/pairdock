#ifndef SCX_HAL_I2C_H
#define SCX_HAL_I2C_H

#include <stddef.h>
#include <stdint.h>
#include "scx_error.h"

#ifdef __cplusplus
extern "C" {
#endif

scx_error_t scx_hal_i2c_init(int bus, uint32_t frequency_hz);
scx_error_t scx_hal_i2c_write(int bus, uint8_t address, const uint8_t *data, size_t length);
scx_error_t scx_hal_i2c_read(int bus, uint8_t address, uint8_t *buffer, size_t length);

#ifdef __cplusplus
}
#endif

#endif
