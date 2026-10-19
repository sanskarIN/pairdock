#include "scx_hal_pwm.h"

scx_error_t scx_hal_pwm_init(int channel, uint32_t frequency_hz) {
  return channel >= 0 && frequency_hz > 0 ? SCX_OK : SCX_ERROR_INVALID_ARGUMENT;
}

scx_error_t scx_hal_pwm_set_duty(int channel, float duty_cycle) {
  if (channel < 0 || duty_cycle < 0.0f || duty_cycle > 1.0f) {
    return SCX_ERROR_INVALID_ARGUMENT;
  }
  return SCX_OK;
}
