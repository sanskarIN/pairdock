#include "scx_hal_adc.h"

scx_error_t scx_hal_adc_init(int channel) {
  return channel >= 0 ? SCX_OK : SCX_ERROR_INVALID_ARGUMENT;
}

scx_error_t scx_hal_adc_read(int channel, uint16_t *millivolts) {
  if (channel < 0 || millivolts == 0) {
    return SCX_ERROR_INVALID_ARGUMENT;
  }
  *millivolts = 3300;
  return SCX_OK;
}
