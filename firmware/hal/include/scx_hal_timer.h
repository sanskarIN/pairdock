#ifndef SCX_HAL_TIMER_H
#define SCX_HAL_TIMER_H

#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

uint64_t scx_hal_timer_millis(void);
void scx_hal_timer_delay_ms(uint32_t delay_ms);

#ifdef __cplusplus
}
#endif

#endif

