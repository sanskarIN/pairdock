#ifndef SCX_HAL_ADC_H
#define SCX_HAL_ADC_H

#include <stdint.h>
#include "scx_error.h"

#ifdef __cplusplus
extern "C" {
#endif

scx_error_t scx_hal_adc_init(int channel);
scx_error_t scx_hal_adc_read(int channel, uint16_t *millivolts);

#ifdef __cplusplus
}
#endif

#endif

