#ifndef SCX_HAL_PWM_H
#define SCX_HAL_PWM_H

#include <stdint.h>
#include "scx_error.h"

#ifdef __cplusplus
extern "C" {
#endif

scx_error_t scx_hal_pwm_init(int channel, uint32_t frequency_hz);
scx_error_t scx_hal_pwm_set_duty(int channel, float duty_cycle);

#ifdef __cplusplus
}
#endif

#endif

