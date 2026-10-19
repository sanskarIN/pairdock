#ifndef SCX_HAL_SPI_H
#define SCX_HAL_SPI_H

#include <stddef.h>
#include <stdint.h>
#include "scx_error.h"

#ifdef __cplusplus
extern "C" {
#endif

scx_error_t scx_hal_spi_init(int bus, uint32_t frequency_hz);
scx_error_t scx_hal_spi_transfer(int bus, const uint8_t *tx, uint8_t *rx, size_t length);

#ifdef __cplusplus
}
#endif

#endif
