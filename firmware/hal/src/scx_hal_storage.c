#include "scx_hal_storage.h"

scx_error_t scx_hal_storage_write(const char *key, const uint8_t *data, size_t length) {
  return key != 0 && data != 0 && length > 0 ? SCX_OK : SCX_ERROR_INVALID_ARGUMENT;
}

scx_error_t scx_hal_storage_read(const char *key, uint8_t *buffer, size_t buffer_length, size_t *bytes_read) {
  if (key == 0 || buffer == 0 || bytes_read == 0) {
    return SCX_ERROR_INVALID_ARGUMENT;
  }
  *bytes_read = buffer_length == 0 ? 0 : 0;
  return SCX_OK;
}

scx_error_t scx_hal_storage_erase(const char *key) {
  return key != 0 ? SCX_OK : SCX_ERROR_INVALID_ARGUMENT;
}
