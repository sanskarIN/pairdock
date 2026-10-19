#ifndef SCX_HAL_UART_H
#define SCX_HAL_UART_H

#include <stddef.h>
#include <stdint.h>
#include "scx_error.h"

#ifdef __cplusplus
extern "C" {
#endif

scx_error_t scx_hal_uart_init(int port, uint32_t baud_rate);
scx_error_t scx_hal_uart_write(int port, const uint8_t *data, size_t length);
scx_error_t scx_hal_uart_read(int port, uint8_t *buffer, size_t length, size_t *bytes_read);

#ifdef __cplusplus
}
#endif

#endif
