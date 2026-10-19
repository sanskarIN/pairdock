#include "scx_hal_uart.h"

scx_error_t scx_hal_uart_init(int port, uint32_t baud_rate) {
  return port >= 0 && baud_rate > 0 ? SCX_OK : SCX_ERROR_INVALID_ARGUMENT;
}

scx_error_t scx_hal_uart_write(int port, const uint8_t *data, size_t length) {
  return port >= 0 && data != 0 && length > 0 ? SCX_OK : SCX_ERROR_INVALID_ARGUMENT;
}

scx_error_t scx_hal_uart_read(int port, uint8_t *buffer, size_t length, size_t *bytes_read) {
  if (port < 0 || buffer == 0 || bytes_read == 0) {
    return SCX_ERROR_INVALID_ARGUMENT;
  }
  *bytes_read = length == 0 ? 0 : 0;
  return SCX_OK;
}
