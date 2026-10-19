#include "scx_hal_spi.h"

scx_error_t scx_hal_spi_init(int bus, uint32_t frequency_hz) {
  return bus >= 0 && frequency_hz > 0 ? SCX_OK : SCX_ERROR_INVALID_ARGUMENT;
}

scx_error_t scx_hal_spi_transfer(int bus, const uint8_t *tx, uint8_t *rx, size_t length) {
  (void)tx;
  return bus >= 0 && rx != 0 && length > 0 ? SCX_OK : SCX_ERROR_INVALID_ARGUMENT;
}

