#ifndef SCX_HAL_STORAGE_H
#define SCX_HAL_STORAGE_H

#include <stddef.h>
#include <stdint.h>
#include "scx_error.h"

#ifdef __cplusplus
extern "C" {
#endif

scx_error_t scx_hal_storage_write(const char *key, const uint8_t *data, size_t length);
scx_error_t scx_hal_storage_read(const char *key, uint8_t *buffer, size_t buffer_length, size_t *bytes_read);
scx_error_t scx_hal_storage_erase(const char *key);

#ifdef __cplusplus
}
#endif

#endif

