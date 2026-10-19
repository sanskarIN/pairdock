#include "scx_hal_i2c.h"

scx_error_t scx_hal_i2c_init(int bus, uint32_t frequency_hz) {
  return bus >= 0 && frequency_hz > 0 ? SCX_OK : SCX_ERROR_INVALID_ARGUMENT;
}

scx_error_t scx_hal_i2c_write(int bus, uint8_t address, const uint8_t *data, size_t length) {
  (void)address;
  return bus >= 0 && data != 0 && length > 0 ? SCX_OK : SCX_ERROR_INVALID_ARGUMENT;
}

scx_error_t scx_hal_i2c_read(int bus, uint8_t address, uint8_t *buffer, size_t length) {
  (void)address;
  return bus >= 0 && buffer != 0 && length > 0 ? SCX_OK : SCX_ERROR_INVALID_ARGUMENT;
}
